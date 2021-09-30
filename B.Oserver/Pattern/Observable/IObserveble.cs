using B.Oserver.Pattern.Observer;

namespace B.Oserver.Pattern.Observable
{
    interface IObserveble
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
