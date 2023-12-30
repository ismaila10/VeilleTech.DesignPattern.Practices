using VeilleTech.DesignPattern.Practices.CreationalDesignPattern.SimpleFactoryPattern;

namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.FactoryMethodPattern
{
    public abstract class IAnimalFactory
    {
        public IAnimal MakeAnimal()
        {
            Console.WriteLine("IAnimalFactory.MakeAnimal() -You cannot ignore parent rules. ");
            /* At this point, it doesn't know whether it will get a Cat or a Tiger. It will be decided by the subclasses
          i.e.CatFactory or TigerFactory. But it knows that it will Speak and it will have a preferred way of Action.
          */

            IAnimal animal = CreateAnimal();
            animal.Speak();
            animal.Action();

            return animal;
        }

        public abstract IAnimal CreateAnimal();
    }
}
