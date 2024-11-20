
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace lesson2_2.Controllers;
public class OrderController : BaseController
{
IOrderManager _order;
public OrderController(IOrderManager order)
{
    _order = order;
}
    public IEnumerable<object> PizzaList { get; private set; }

    public OrderController(IServiceCollection services)
    {
        services.AddControllers();
        services.AddMvc();

    }

    }