namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.AbstractFactoryPattern
{
    public class PetCat : ICat
    {
        public void Action()
        {
            Console.WriteLine("Pet Cat prefer to stay at home.\n\n");
        }

        public void Speak()
        {
            Console.WriteLine("Pet Cat says: Miaouh...\n");
        }
    }
}
