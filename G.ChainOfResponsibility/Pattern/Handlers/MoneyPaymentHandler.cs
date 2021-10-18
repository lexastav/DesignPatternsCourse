using G.ChainOfResponsibility.Pattern.Handlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.ChainOfResponsibility.Pattern.Handlers
{
    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer)
            {
                Console.WriteLine("Выполняем перевод через системы денежных переводов");
            }
            else if (Successor is not null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
