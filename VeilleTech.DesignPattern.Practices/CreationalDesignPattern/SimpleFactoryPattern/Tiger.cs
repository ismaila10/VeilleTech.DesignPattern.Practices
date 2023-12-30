namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.SimpleFactoryPattern
{
    public class Tiger : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Tigers prefer hunting...\n\n");
        }

        public void Speak()
        {
            Console.WriteLine("Tiger says: Halum...\n");
        }
    }
}
