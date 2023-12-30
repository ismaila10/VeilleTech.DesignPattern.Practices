using VeilleTech.DesignPattern.Practices.CreationalDesignPattern.SimpleFactoryPattern;

namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.FactoryMethodPattern
{
    public class CatFactory : IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            //Creating a Cat
            return new Cat();
        }
    }
}
