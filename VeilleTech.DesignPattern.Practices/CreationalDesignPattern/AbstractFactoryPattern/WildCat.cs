namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.AbstractFactoryPattern
{
    public class WildCat : ICat
    {
        public void Action()
        {
            Console.WriteLine("Wild Cat prefer to roam freely in jungles.\n\n");
        }

        public void Speak()
        {
            Console.WriteLine("Wild Cat says: Miaouh...\n");
        }
    }
}
