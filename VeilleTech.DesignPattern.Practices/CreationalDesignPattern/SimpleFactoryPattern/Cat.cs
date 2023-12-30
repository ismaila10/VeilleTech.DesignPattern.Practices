namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.SimpleFactoryPattern
{
    public class Cat : IAnimal
    {

        public void Action()
        {
            Console.WriteLine("Cat prefer meowing...\n\n");            
        }

        public void Speak()
        {
            Console.WriteLine("Cat says: Miaouh...\n");
        }
    }
}
