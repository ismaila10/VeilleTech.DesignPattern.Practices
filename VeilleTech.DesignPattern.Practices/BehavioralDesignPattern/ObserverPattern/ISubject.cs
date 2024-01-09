namespace VeilleTech.DesignPattern.Practices.BehavioralDesignPattern.ObserverPattern
{
    public interface ISubject
    {
        void Register(IObserver o);
        void Unregister(IObserver o);
        void NotifyRegisteredUsers(int i);
    }
}
