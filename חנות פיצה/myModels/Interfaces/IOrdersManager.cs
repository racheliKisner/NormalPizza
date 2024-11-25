namespace myModels.Interfaces;

public interface IOrdersManager{

	 bool addOrder(int id, int pay, bool ifPay);
    void addPizza(int id,int pay,bool ifPay);
}