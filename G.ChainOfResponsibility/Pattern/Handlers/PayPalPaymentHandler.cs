using G.ChainOfResponsibility.Pattern.Handlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.ChainOfResponsibility.Pattern.Handlers
{
    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPallTransfer)
            {
                Console.WriteLine("Выполняем перевод через PayPall");
            }
            else if (Successor is not null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
