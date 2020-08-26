 class Dog {
     public string Name { get; set;}

     public int Age { get; set ;}

     public void bark(){
         Console.writeLine("wool wof");
     }

 }

 class DogShow { //view
     public void printDogInfo(string name , int age)
     {
         Console.writeLine("\n Dig is {0} and it is {1} years old \n",name,age);
     }
 }

 class DogController{
     private Dog model;
     private DogShow view;

     public DogController( Dog model,DogShow view){
         this.model = model;
         this.view = view ;
     }
     public void setName(string name)
     {
         model.Name =name;
     }

     
     public void setAge(int age)
     {
         model.Age =age;
     }
      public void getName()
     {
         return model.Name;
     }
     public void getAge()
     {
         return model.Age;
     }

     public void updateView(){
         view.printDogInfo(model.Name,model.Age);
     }
 }

class Program{  //main
    static void Main(string[] args)
    {
    Dog myDog = getInfoFromDB();
    DogShow show = new DogShow();

    DogController ctrl = new DogController(myDog , show);

    ctrl.updateView();
    ctrl.setName("snow");
    ctrl.setAge(4);
    strl.updateView();
    Console.ReadLine();
    }


 private static Dog getInfoFromDB(){  //fordatabase
     Dog d = new Dog();   
     d.Name = "Blck";
     d.Age = 3 ;
 }

}
 