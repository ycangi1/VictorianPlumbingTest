using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VictorainPlumbing.Domain;
using VictorianPlumbingTest.Dto;
using VictorianPlumbingTest.Repository;
using VictorianPlumbingTest.Services.Interfaces;

namespace VictorianPlumbingTest.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<OrderDto> Order(OrderDto order)
        {
            var productsToAdd = new List<Product>();
            var invalidProductNames = new List<string>();
            var allProducts = await _unitOfWork.Product.GetAll();
            foreach (var product in order.Products)
            {
                var foundProduct = allProducts.FirstOrDefault(x => x.Name.ToLower() == product.Name.ToLower());

                if (foundProduct == null)
                {
                    invalidProductNames.Add(product.Name);
                }
                else
                {
                    productsToAdd.Add(foundProduct);
                }
            }

            if (invalidProductNames.Any())
            {

                throw new Exception("Products not found: " + string.Join(", ", invalidProductNames));
            }

            var orderToAdd = _mapper.Map<Order>(order);

            orderToAdd.Products = productsToAdd;
            orderToAdd.OrderedAt = DateTime.Now;

            var result = await _unitOfWork.Order.Add(orderToAdd);

            _unitOfWork.SaveChanges();

            var productOrder = productsToAdd.Select(x =>
            new ProductOrder
            {
                OrderId = result.OrderId,
                ProductId = x.ProductId
            }).ToList();

            _unitOfWork.ProductOrder.AddRange(productOrder);

            _unitOfWork.SaveChanges();
            return order;
        }
    }
}
