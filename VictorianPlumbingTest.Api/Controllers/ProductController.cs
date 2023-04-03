using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using VictorianPlumbingTest.Dto;
using VictorianPlumbingTest.Services.Interfaces;

namespace VictorianPlumbingTest.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(ILogger<ProductController> logger, IProductService productService,
          IMapper mapper)
        {
            _logger = logger;
            _productService = productService;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> Get()
        {
            var results = await _productService.GetAllProducts();

            return  _mapper.Map<IEnumerable<ProductDto>>(results);

        }
    }
}
