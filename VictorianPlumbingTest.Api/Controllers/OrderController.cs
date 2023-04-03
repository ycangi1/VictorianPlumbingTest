using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Web.Http;
using VictorianPlumbingTest.Dto;
using VictorianPlumbingTest.Services.Interfaces;

namespace VictorianPlumbingTest.Api.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(ILogger<ProductController> logger, IOrderService orderService,
          IMapper mapper)
        {
            _logger = logger;
            _orderService = orderService;
            _mapper = mapper;

        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task<OrderDto> Order(OrderDto order)
        {
            var results = await _orderService.Order(order);

            return _mapper.Map<OrderDto>(results);

        }
    }
}
