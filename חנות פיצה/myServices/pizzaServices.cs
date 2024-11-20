
using myModels;
using myModels.Interfaces;
namespace myServices;
public class PizzaServices : PizzaController,IPizzaManager
{
    private List<Pizza> pizzaList = new List<Pizza>()
    {
        new Pizza("margarita",true,111),
        new Pizza("bluma",true,222),
        new Pizza("rivka",false,333),
        new Pizza("zeava",true,444),
    };

    public  List<Pizza> PizzaList { get => pizzaList; set => pizzaList = value; }

    

    public Pizza get(int id)
    {
        foreach (var i in PizzaList)
        {
            if (i.id == id)
            {
                return i;
            }
        }
        return null;
    }
   
    public void postPizza(string name, bool isGluten, int id)
    {
        PizzaList.Add(new Pizza(name, isGluten, id));
        
    }
    
    public Pizza getByName(string name)
    {
        foreach (var i in PizzaList)
        {
            if (i.name == name)
            {
                return i;
            }
        }
        return null;
    }

    
    public Boolean deleteById(int id)
    {
        foreach (var i in PizzaList)
        {
            if (i.id == id)
            {
                PizzaList.Remove(i);
                return true;
            }
        }
        return false;
    }


    bool IPizzaManager.getByName(string name)
    {
        throw new NotImplementedException();
    }

    bool IPizzaManager.postPizza(string name, bool isGluten, int id)
    {
        throw new NotImplementedException();
    }
}