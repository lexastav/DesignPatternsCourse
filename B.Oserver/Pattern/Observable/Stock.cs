using B.Oserver.Pattern.Models;
using B.Oserver.Pattern.Observer;
using System.Collections.Generic;

namespace B.Oserver.Pattern.Observable
{
    class Stock : IObserveble
    {
        StockInfo stockInfo;

        List<IObserver> observers;
        public Stock()
        {
            observers = new List<IObserver>();
            stockInfo = new StockInfo();
        }

        public void RegisterObserver(IObserver observer) { observers.Add(observer); }
        public void RemoveObserver(IObserver observer) { observers.Remove(observer); }
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(stockInfo);
            }
        }
        public void Market()
        {
            System.Random random = new System.Random();
            stockInfo.USD = random.Next(70, 80);
            stockInfo.Euro = random.Next(80, 100);
            NotifyObservers();
        }
    }
}
