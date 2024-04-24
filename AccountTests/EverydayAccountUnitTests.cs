using BankApplication;

namespace AccountTests
{
    [TestClass]
    public class EverydayAccountUnitTests
    {
        [TestMethod]
       public void EverydayAccount_deposit()
        {
            //arrange
            EverydayAccount b = new EverydayAccount(100);
             double initialBalance = b.Balance;  

            //act
            b.Deposit(50);
            //assert
            double expected = initialBalance + 50;
            double actual = b.Balance;
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
       public void EverydayAccount_Withdrawal()
        {
            //arrange
            EverydayAccount b = new EverydayAccount(100);
             double initialBalance = b.Balance;  

            //act
            b.Withdraw(50);
            //assert
            double expected = initialBalance - 50;
            double actual = b.Balance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(EverydayAccountException))]
        
        public void EverydayAccount_FailWithdrawal_OverWithdrawal()
        {
           
            EverydayAccount b = new EverydayAccount(300);
            b.Withdraw(400);
        }

        [TestMethod]
        [ExpectedException(typeof(EverydayAccountException))]
        public void EverydayAccount_FailWithdrawal_NegativeWithdrawal()
        {        
            EverydayAccount b = new EverydayAccount(100);
            b.Withdraw(-5);
        }
    }
}