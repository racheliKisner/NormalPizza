using myModels;
using myModels.Interfaces; 


namespace myServices;

public class WorkerService: IWorker
{

     List <Worker> workerList=new List<Worker>
    {
        new Worker("chaim",20,1548),
        new Worker("moshe",25,45987),
        new Worker("tamir",30,46546),
        new Worker("shlomo",40,746874),
        new Worker("rami",30,17467),
    };

    

    public Worker GetId(int id)
    {
        foreach(var i in WorkerList)
        {
            if(i.id==id)
            {
               return i;
            }
           
        }
         return null;
    }
    public Worker GetNmae(string name)
    {
        foreach(var i in WorkerList)
        {
            if(i.name==name)
            {
                return i;
            }
            
        }
        return null;
    }
    public bool updateAge(int age,int id)
    {
        foreach(var i in WorkerList)
        {
            if(i.id==id)
            {
                i.age=age;
                return true;
            }
           
        }
         return false;
    }
     public bool addWorker(string name,int age,int id)
    {
        WorkerList.Add(new Worker(name,age,id));
        return  true;
    }
    public Worker deleteWorker(int id)
    {
         foreach(var i in WorkerList)
        {
            if(i.id==id)
            {
                WorkerList.Remove(i);
                return i;
            }
            
        }
        return null;
    }

}