using myModels;

public class Pizza
{
    
        public string pizzaName { get; set; }
        public int pizzaId {get; set;}

        public bool ifGloten{ get; set; }
        public Pizza(string pizzaName,int pizzaId,bool ifGloten)
        {
            this.pizzaName=pizzaName;
            this.pizzaId=pizzaId;
            this.ifGloten=ifGloten;
        }
}