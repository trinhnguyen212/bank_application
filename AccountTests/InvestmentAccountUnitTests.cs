using BankApplication;

namespace AccountTests
{
    [TestClass]
    public class InvestmentAccountUnitTests
    {
        [TestMethod]
        public void InvestmentAccount_deposit()
        {
            //arrange          
            InvestmentAccounts b = new InvestmentAccounts(0.01m, 10, 200);
            double initialBalance = b.Balance;

            //act
            b.Deposit(50);
            //assert
            double expected = initialBalance + 50;
            double actual = b.Balance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvestmentAccount_Withdrawal()
        {
            //arrange
            InvestmentAccounts b = new InvestmentAccounts(0.01m, 10, 200);
            double initialBalance = b.Balance;

            //act
            b.Withdraw(50);
            //assert
            double expected = initialBalance - 50;
            double actual = b.Balance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvestmentAccount_CaculateTransFee()
        {
            //arrange
            InvestmentAccounts b = new InvestmentAccounts(0.01m, 10, 200);
            Customer customer = new Customer("tracy", "tracy@mail", true);

            //act
            b.Withdraw(10);

            double x = b.CaculateTransFee(customer);

            //assert
            double expected = 0;
            double actual = x;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void InvestmentAccount_ApplyInterest()
        {
            //arrange
            InvestmentAccounts b = new InvestmentAccounts(0.01m, 10, 200);

            //act
            b.CaCulatedInterest();
            b.ApplyInterest();
            double x = b.Balance;
            //assert
            double expected = 202;
            double actual = x;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(InvestmentAccountException))]

        public void InvestmentAccount_FailWithdrawal_OverWithdrawal()
        {
            InvestmentAccounts b = new InvestmentAccounts(0.01m, 10, 200);
            b.Withdraw(400);
        }

        [TestMethod]
        [ExpectedException(typeof(InvestmentAccountException))]
        public void InvestmentAccount_FailWithdrawal_NegativeWithdrawal()
        {
            InvestmentAccounts b = new InvestmentAccounts(0.01m, 10, 200);
            b.Withdraw(-5);
        }
    }
}
