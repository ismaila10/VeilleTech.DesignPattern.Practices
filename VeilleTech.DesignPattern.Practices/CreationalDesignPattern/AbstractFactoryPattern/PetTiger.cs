namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.AbstractFactoryPattern
{
    public class PetTiger : ITiger
    {
        public void Action()
        {
            Console.WriteLine("Pet Tigers play in an animal circus.\n");
        }

        public void Sleep()
        {
            Console.WriteLine("Pet tiger seeping noise Hummmmmmmmmmmmmmmmmmmmmmm \n");
        }

        public void Speak()
        {
            Console.WriteLine("Pet Tiger says: Halum.\n");
        }
    }
}
