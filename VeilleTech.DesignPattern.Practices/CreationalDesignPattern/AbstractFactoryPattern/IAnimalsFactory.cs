namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.AbstractFactoryPattern
{
    public interface IAnimalsFactory
    {
        ICat GetCat();

        ITiger GetTiger();
    }
}
