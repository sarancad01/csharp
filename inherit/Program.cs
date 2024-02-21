
/*
  // base class
  class Animal { 

    public string name;

    public void display() {
      Console.WriteLine("I am an animal");
    }
    
  } 
  
  // derived class of Animal 
  class Dog : Animal {
    
    public void getName() {
      Console.WriteLine("My name is " + name);
    }
  }

  class Program {

    static void Main(string[] args) {

      // object of derived class
      Dog labrador = new Dog();

      // access field and method of base class
      labrador.name = "sira";
      labrador.display();

      // access method from own class
      labrador.getName();

      Console.ReadLine();
    }

  }
*/

class Kalaingar{

    public string location;
    
    public Kalaingar()
    {
        Console.WriteLine("Welcome to Kalaingar family");
    }
    public string partyname(string ppartyname){
        
        return "I have Political Party " + ppartyname ;

    }


}

class mkstalin : Kalaingar
{
     public mkstalin(string name){
        location = "gopalapuram";
        Console.WriteLine(partyname(name) + " " + location);
     }
}


class mkazhagiri : Kalaingar
{
     public mkazhagiri(string name){
         location = "Madurai";
         Console.WriteLine(partyname(name) + " " + location);
     }
}

class family{

    static void Main(string [] args){
       // Kalaingar kr=new Kalaingar();
       mkstalin stalin=new mkstalin("dmk");
       mkazhagiri azhagiri=new mkazhagiri("dmk");
        

    }
}