using myModels;
using myModels.Interfaces; 

namespace myServices.Services;
public class OrderServices : IOrdersManager
{
    List<Orders> o1=new List<Orders>()
    {
        new Orders("54645336",DateTime.Now,9),
        new Orders("45845484",DateTime.Now,3),
        new Orders("64954566",DateTime.Now,7)
    };
    void setOrder(string CustomerId, DateTime Date,decimal TotalAmount)
    {
        Orders o2=new Orders(CustomerId,Date,TotalAmount);
        o1.Add(o2);
    }

    void IOrdersManager.setOrder(string CustomerId, DateTime Date, decimal TotalAmount)
    {
        throw new NotImplementedException();
    }
}