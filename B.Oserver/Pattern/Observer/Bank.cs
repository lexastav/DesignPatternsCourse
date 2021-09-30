using B.Oserver.Pattern.Observable;
using B.Oserver.Pattern.Models;

namespace B.Oserver.Pattern.Observer
{
    class Bank : IObserver
    {
        public string Name { get; set; }
        IObserveble stock;
        public Bank(string name, IObserveble observeble)
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
                System.Console.WriteLine($"Банк {this.Name} продает евро; Курс евро {stockInfo.Euro}");
            }
            else
            {
                System.Console.WriteLine($"Банк {this.Name} покупает евро; Курс евро {stockInfo.Euro}");
            }
        }
        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
