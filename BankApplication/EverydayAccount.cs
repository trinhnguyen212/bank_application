using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class EverydayAccount : BankAccounts
    {
        public EverydayAccount(double blance): base()
        {
            this.Balance = blance;
        }
        public override void Withdraw(double amount)
        {
            if (amount < 0)
            {

                throw new EverydayAccountException("< 0 . \n **The Withdrawal must be > 0**", ((decimal)amount));
            }

            if (amount > Balance)
            {
                decimal x = ((decimal)(Balance - amount));
                throw new EverydayAccountException($"> Balance = {Balance} . \n **Not Enough Balance**",((decimal)amount));

            }

            Balance -= amount;


        }
    }
}
