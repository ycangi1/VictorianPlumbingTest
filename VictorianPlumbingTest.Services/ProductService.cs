using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VictorainPlumbing.Domain;
using VictorianPlumbingTest.Repository;
using VictorianPlumbingTest.Services.Interfaces;

namespace VictorianPlumbingTest.Services
{
    public class ProductService : IProductService
    {

        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
           return await _unitOfWork.Product.GetAll();
        }
    }
}
