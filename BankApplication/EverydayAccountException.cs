using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class EverydayAccountException : FailedWithdrawalExcception
    {
        public EverydayAccountException(
            string message
        )
            : base(message)
        {
        }
           public EverydayAccountException(string message, decimal deficit) : base(message,deficit)
        {
           Deficit = deficit;
           FailedMessage = message;
        }


        public override string Message =>
            $"Everyday Account Failed Withdrawal Exception:\n Withdrawal Amount = {Deficit:C} {FailedMessage}";

    }
}
