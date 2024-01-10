namespace VeilleTech.DesignPattern.Practices.BehavioralDesignPattern.ObserverPattern
{
    public class ObserverType1 : IObserver
    {
        string NameOfObserver;

        public ObserverType1(string name)
        {
            this.NameOfObserver = name;
        }

        public void Update(int i)
        {
            Console.WriteLine($"{NameOfObserver} has received an alert: Someone has updated DB flag Value in Subject to: {i} \n");
        }
    }
}
