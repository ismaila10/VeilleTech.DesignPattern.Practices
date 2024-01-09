namespace VeilleTech.DesignPattern.Practices.BehavioralDesignPattern.ObserverPattern
{
    public class ObserverType1 : IObserver
    {
        string nameOfObserver;
        public ObserverType1(String name)
        {
            this.nameOfObserver = name;
        }

        public void Update(int i)
        {
            Console.WriteLine($"{nameOfObserver} has received an alert: Someone has updated DB flag Value in Subject to: {i} \n");
        }
    }
}
