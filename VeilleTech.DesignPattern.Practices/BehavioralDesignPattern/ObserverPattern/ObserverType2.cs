namespace VeilleTech.DesignPattern.Practices.BehavioralDesignPattern.ObserverPattern
{
    public class ObserverType2 : IObserver
    {
        string NameOfObserver;

        public ObserverType2(string name)
        {
            this.NameOfObserver = name;
        }

        public void Update(int i)
        {
            Console.WriteLine($"{NameOfObserver} notified: DB flag Value in Subject at present: {i} \n");
        }
    }
}
