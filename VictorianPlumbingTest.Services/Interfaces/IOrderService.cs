using System.Threading.Tasks;
using VictorainPlumbing.Domain;
using VictorianPlumbingTest.Dto;

namespace VictorianPlumbingTest.Services.Interfaces
{
    public interface IOrderService
    {
        Task<OrderDto> Order(OrderDto order);
    }
}
