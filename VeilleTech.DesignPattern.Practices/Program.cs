using System;
using VeilleTech.DesignPattern.Practices.BehavioralDesignPattern.ObserverPattern;
using VeilleTech.DesignPattern.Practices.CreationalDesignPattern.AbstractFactoryPattern;
using VeilleTech.DesignPattern.Practices.CreationalDesignPattern.FactoryMethodPattern;
using VeilleTech.DesignPattern.Practices.CreationalDesignPattern.SimpleFactoryPattern;
using VeilleTech.DesignPattern.Practices.CreationalDesignPattern.SingletonDesignPattern;


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

Console.ReadLine();
#endregion


#region Run this region to check Factory Method Pattern Demo
Console.WriteLine("--------------------------- Factory Method Pattern Demo ----------------------------");
IAnimalFactory catFactory = new CatFactory();
Console.WriteLine("CatFactory can create only Cat Animals !");
IAnimal aCat = catFactory.CreateAnimal();
Console.WriteLine("Cat Animal created with its features !");

IAnimal aCat1 = catFactory.MakeAnimal();

Console.ReadLine();
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


#region Run this region to check Singleton Pattern Demo
Console.WriteLine("--------------------------- Singleton Pattern Demo ----------------------------");
Console.WriteLine("Trying to create instance s1.\n\n");
Singleton s1 = Singleton.Instance;
Console.WriteLine("Trying to create instance s2.\n\n");
Singleton s2 = Singleton.Instance;
if (s1 == s2)
{
    Console.WriteLine("Only one instance exists.\n\n");
}
else
{
    Console.WriteLine("Different instances exist.\n\n");
}

Console.WriteLine("***Thread-Safe Singleton Pattern Demo***\n\n");
Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );
static void TestSingleton(string value)
{
    SingletonTS singleton = SingletonTS.Instance(value);
    Console.WriteLine(singleton.Value);
}
Thread process1 = new Thread(() =>
{
    TestSingleton("FOO");
});
Thread process2 = new Thread(() =>
{
    TestSingleton("BAR");
});

process1.Start();
process2.Start();

process1.Join();
process2.Join();

Console.ReadLine();
#endregion


#region Run this region to check Observer Pattern Demo
Console.WriteLine("--------------------------- Observer Pattern Demo ----------------------------");
//We have 3 observers-2 of them are ObserverType1, 1 of them is of ObserverType2
IObserver myObserver1 = new ObserverType1("DB Subscriber 1");
IObserver myObserver2 = new ObserverType1("DB Subscriber 2");
IObserver myObserver3 = new ObserverType2("DB Subscriber 3");
Subject subject = new Subject();
//Registering the observers-DB Users
subject.Register(myObserver1);
subject.Register(myObserver2);
subject.Register(myObserver3);
Console.WriteLine("Updating Flag = 5 \n");
subject.Flag = 5;
//Unregistering an observer(DB Subscriber 1))
subject.Unregister(myObserver1);
//No notification this time DB Subscriber 1. Since it is unregistered.
Console.WriteLine("\nUpdating Flag = 50 \n");
subject.Flag = 50;
//DB Subscriber 1 is registering himself again
subject.Register(myObserver1);
Console.WriteLine("\nUpdating Flag = 100 \n");
subject.Flag = 100;

Console.ReadLine();
#endregion
