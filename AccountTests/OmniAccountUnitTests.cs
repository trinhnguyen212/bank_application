using BankApplication;

namespace AccountTests
{
    [TestClass]
    public class OmniAccountUnitTests
    {
        [TestMethod]
        public void OmniAccount_deposit()
        {
            //arrange          
            OmniAccounts b = new OmniAccounts(0.01m, 100, 10, 200);
            double initialBalance = b.Balance;


            //act
            b.Deposit(50);
            //assert
            double expected = initialBalance + 50;
            double actual = b.Balance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OmniAccount_Withdrawal()
        {
            //arrange
            OmniAccounts b = new OmniAccounts(0.01m, 100, 10, 200);
            double initialBalance = b.Balance;

            //act
            b.Withdraw(50);
            //assert
            double expected = initialBalance - 50;
            double actual = b.Balance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OmniAccount_CaculateTransFee()
        {
            //arrange
            OmniAccounts b = new OmniAccounts(0.01m, 100, 10, 200);
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
        public void OmniAccount_ApplyInterest()
        {
            //arrange
            OmniAccounts b = new OmniAccounts(0.01m, 100, 10, 200);


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
        [ExpectedException(typeof(OmniAccountException))]

        public void OmniAccount_FailWithdrawal_OverWithdrawal()
        {
            OmniAccounts b = new OmniAccounts(0.01m, 100, 10, 200);

            b.Withdraw(400);
        }

        [TestMethod]
        [ExpectedException(typeof(OmniAccountException))]
        public void InvestmentAccount_FailWithdrawal_NegativeWithdrawal()
        {
            OmniAccounts b = new OmniAccounts(0.01m, 100, 10, 200);
            b.Withdraw(-5);
        }
    }
}
