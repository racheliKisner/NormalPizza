
namespace myModels.Interfaces;
public interface IpizzaMannager
{
    List<Pizza> getPizzaList();
    Pizza getPizza(int id);
    Pizza getPizzaByName(string name);
    void setPizza(string name, int id, bool ifGloten);
	bool deletePizza(int id);   
	bool updatePizza(int id, bool ifGloten);
}