
#region Run this region to check Simple Factory Pattern Demo
using VeilleTech.DesignPattern.Practices.CreationalDesignPattern.SimpleFactoryPattern;

IAnimal? preferedtype = null;
ISimpleFactory simpleFactory = new SimpleFactory();
Console.WriteLine("Veuillez choisir un animal ");
Console.WriteLine("0 : Cat ");
Console.WriteLine("1 : Tiger");
var userInput = Console.ReadLine();

if (!int.TryParse(userInput, out int number))
{
    Console.WriteLine("Saisie invalide. Veuillez entrer un chiffre entier.");
    return;
}

preferedtype = simpleFactory.CreateAnimal(number);
preferedtype.Speak();
preferedtype.Action();
Console.ReadLine();
#endregion
