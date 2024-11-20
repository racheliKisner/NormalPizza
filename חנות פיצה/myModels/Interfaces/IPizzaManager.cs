
namespace myModels.Interfaces;
using System;
public interface IPizzaManager
{
    public Boolean putGlutenById(bool isGluten, int id);
    public Boolean deleteById(int id);
    public Boolean getByName(string name);
    public Boolean postPizza(string name, bool isGluten, int id);

}