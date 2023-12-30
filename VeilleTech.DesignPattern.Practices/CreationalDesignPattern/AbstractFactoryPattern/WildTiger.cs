namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.AbstractFactoryPattern
{
    public class WildTiger : ITiger
    {
        public void Action()
        {
            Console.WriteLine("Wild Tigers prefer hunting in jungles.\n");
        }

        public void Sleep()
        {
            Console.WriteLine("Wild tiger seeping noise Grrrrrrrrrrrrrrrrrrr \n");
        }

        public void Speak()
        {
            Console.WriteLine("Wild Tiger says: Halum.\n");
        }
    }
}
