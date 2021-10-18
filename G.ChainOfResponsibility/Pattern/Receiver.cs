using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.ChainOfResponsibility.Pattern
{
    class Receiver
    {
        public bool BankTransfer { get; set; }
        public bool MoneyTransfer { get; set; }
        public bool PayPallTransfer { get; set; }
        public Receiver(bool bankTransfer, bool moneyTransfer, bool paypalTransfer)
        {
            BankTransfer = bankTransfer;
            MoneyTransfer = moneyTransfer;
            PayPallTransfer = paypalTransfer;
        }
    }
}
