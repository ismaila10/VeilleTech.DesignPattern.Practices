using VeilleTech.DesignPattern.Practices.CreationalDesignPattern.AbstractFactoryPattern;
using VeilleTech.DesignPattern.Practices.CreationalDesignPattern.FactoryMethodPattern;
using VeilleTech.DesignPattern.Practices.CreationalDesignPattern.SimpleFactoryPattern;


#region Run this region to check Simple Factory Pattern Demo
Console.WriteLine("--------------------------- Simple Factory Pattern Demo ----------------------------");
IAnimal? preferedtype = null;
ISimpleFactory simpleFactory = new SimpleFactory();
Console.WriteLine("Please choose an animal ");
Console.WriteLine("0 : Cat ");
Console.WriteLine("1 : Tiger");
var userInput = Console.ReadLine();

if (!int.TryParse(userInput, out int number))
{
    Console.WriteLine("Saisie invalide. Veuillez entrer un chiffre entier.");
    return;
}
// Factory can accept 0 for dog and 1 for tiger
preferedtype = simpleFactory.CreateAnimal(number);
preferedtype.Speak();
preferedtype.Action();
#endregion


#region Run this region to check Factory Method Pattern Demo
Console.WriteLine("--------------------------- Factory Method Pattern Demo ----------------------------");
IAnimalFactory catFactory = new CatFactory();
Console.WriteLine("CatFactory can create only Cat Animals !");
IAnimal aCat = catFactory.CreateAnimal();
Console.WriteLine("Cat Animal created with its features !");

IAnimal aCat1 = catFactory.MakeAnimal();
#endregion


#region Run this region to check Abstract Factory Method Pattern Demo
Console.WriteLine("--------------------------- Abstract Factory Method Pattern Demo ----------------------------");
Console.WriteLine("!!!!!! Making a wild tiger through WildAnimal !!!!!! \n");
IAnimalsFactory wildAnimalFactory = new WildAnimalFactory();
ITiger wildTiger = wildAnimalFactory.GetTiger();
wildTiger.Speak();
wildTiger.Action();
wildTiger.Sleep();

Console.WriteLine("!!!!!! Making a pet cat through PetAnimal !!!!!! \n");
IAnimalsFactory petAnimalFactory = new PetAnimalFactory();
ICat petCat = petAnimalFactory.GetCat();
petCat.Speak();
petCat.Action();
Console.ReadLine();
#endregion
