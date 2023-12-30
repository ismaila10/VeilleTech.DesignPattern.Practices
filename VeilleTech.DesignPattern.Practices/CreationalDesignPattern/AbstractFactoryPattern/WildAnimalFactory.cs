namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.AbstractFactoryPattern
{
    public class WildAnimalFactory : IAnimalsFactory
    {
        public ICat GetCat()
        {
            return new WildCat();
        }

        public ITiger GetTiger()
        {
            return new WildTiger();
        }
    }
}
