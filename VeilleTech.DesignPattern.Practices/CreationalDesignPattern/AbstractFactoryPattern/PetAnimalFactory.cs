namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.AbstractFactoryPattern
{
    public class PetAnimalFactory : IAnimalsFactory
    {
        public ICat GetCat()
        {
            return new PetCat();
        }

        public ITiger GetTiger()
        {
            return new PetTiger();
        }
    }
}
