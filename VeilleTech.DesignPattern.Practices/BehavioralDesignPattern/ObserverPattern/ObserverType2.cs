namespace VeilleTech.DesignPattern.Practices.BehavioralDesignPattern.ObserverPattern
{
    public class ObserverType2 : IObserver
    {
        string nameOfObserver;
        public ObserverType2(String name)
        {
            this.nameOfObserver = name;
        }

        public void Update(int i)
        {
            Console.WriteLine($"{nameOfObserver} notified: DB flag Value in Subject at present: {i} \n");
        }
    }
}
