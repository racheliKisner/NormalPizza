namespace myModels;

public class Pizza{
    
  public string name{get; set;}
    public bool isGluten{get; set;}
    public int id{get; set;}
   
     public Pizza(string name, bool isGluten,int id) 
        {
            this.name = name;
            this.isGluten=isGluten;
            this.id = id;
   
        }
}