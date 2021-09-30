using B.Oserver.Pattern.Observable;
using B.Oserver.Pattern.Models;

namespace B.Oserver.Pattern.Observer
{
    class Broker : IObserver
    {
        public string Name { get; set; }
        IObserveble stock;
        public Broker(string name, IObserveble observeble)
        {
            this.Name = name;
            stock = observeble;
            stock.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            StockInfo stockInfo = (StockInfo)obj;

            if (stockInfo.USD > 75)
            {
                System.Console.WriteLine($"Брокер {this.Name} продает доллары; Курс доллара {stockInfo.USD}");
            }
            else
            {
                System.Console.WriteLine($"Брокер {this.Name} покупает доллары; Курс доллара {stockInfo.USD}");
            }
        }
        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
