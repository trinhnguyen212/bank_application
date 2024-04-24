using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class FailedWithdrawalExcception : Exception
    {
        public decimal Deficit
        {
            get;
            set;
        }
        public string FailedMessage
        {
            get;
            set;
        }
        public FailedWithdrawalExcception(string message) : base(message)
        {
        }
        public FailedWithdrawalExcception(string message, decimal deficit)
        {
            Deficit = deficit;
            FailedMessage = message;  
        }
        
    }
}
