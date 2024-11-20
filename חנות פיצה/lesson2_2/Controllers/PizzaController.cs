using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace lesson2_2.Controllers;
public class PizzaController : BaseController
{
IPizzaManager _pizza;
public PizzaController(IPizzaManager pizza)
{
    _pizza = pizza;
}
    public IEnumerable<object> PizzaList { get; private set; }

    public PizzaController(IServiceCollection services)
    {
        services.AddControllers();
        services.AddMvc();

    }
    [Route("[action]/{id}")]
    [HttpGet]
    public IActionResult get(int id)
    {

        var p1 = _pizza.get(id);
        if (p1)
            return Ok(p1);
        return NotFound(null) ;   

    }
    

    // private IActionResult Ok(object name)
    // {
    //     throw new NotImplementedException();
    // }

    [Route("~/[Controller]/getByName/{name}")]
    [HttpGet]
    public IActionResult getByName(String name)
    {
        var p2=_pizza.getByName(name);
       
            if (p2)
            
                return Ok(p2);
            
       
        return NotFound("not found");
    }

    [Route("[action]/{id}")]
    [HttpDelete]
    public Boolean deleteById(int id)
    {
        var p3=_pizza.deleteById(id);
        
            if (!p3)
               return true;
            return false;
            
        
       
    }
    }
    // [Route("[action]/{id}")]
    // [HttpPut]
    // public IActionResult putGlutenById(bool isGluten, int id)
    // {
    //     foreach (var i in PizzaList)
    //     {
    //         if (i.id == id)
    //         {
    //             i.isGluten = isGluten;
    //             return Ok("the pizza update");
    //         }
    //     }
    //     return NotFound("not found");
    // }

