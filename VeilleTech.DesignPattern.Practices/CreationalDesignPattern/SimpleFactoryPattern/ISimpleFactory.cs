namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.SimpleFactoryPattern
{
    public abstract class ISimpleFactory
    {
        public abstract IAnimal CreateAnimal(int selectedAnimal);
    }
}
