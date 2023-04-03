using System.Collections.Generic;
using System.Threading.Tasks;
using VictorainPlumbing.Domain;

namespace VictorianPlumbingTest.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
