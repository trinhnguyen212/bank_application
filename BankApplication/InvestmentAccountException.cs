﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class InvestmentAccountException :FailedWithdrawalExcception
    {
        public InvestmentAccountException(string message) : base(message) { }
        public InvestmentAccountException(string message, decimal deficit) : base(message, deficit)
        {
            Deficit = deficit;
            FailedMessage = message;
        }
        public override string Message =>
            $"Investment Account Failed Withdrawal Exception:\n Withdrawal Amount = {Deficit:C} {FailedMessage}";
    }
}
