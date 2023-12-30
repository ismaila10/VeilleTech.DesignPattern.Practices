using VeilleTech.DesignPattern.Practices.CreationalDesignPattern.SimpleFactoryPattern;

namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.FactoryMethodPattern
{
    public class TigerFactory : IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            //Creating a Tiger
            return new Tiger();
        }
    }
}
