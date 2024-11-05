using System;

namespace BankNUnitTests
{
    public class BankAccountTest
    {

        [Test]
        public void Add_Funds_Update_Balance()
        {
            // ARRANGE
            // put all setups under Arrange
            var account = new BankAccount.BankAccount(1000);

            // ACT
            //here call method to track what to do
            account.Add(500);

            // ASSERT
            // check the final result 
            Assert.AreEqual(1500, account.Balance);

        }


        [Test]
        public void Withdrow_Amount_UpdateBalance()
        {
            var account = new BankAccount.BankAccount(1000);

            account.Withdrow(500);

            Assert.AreEqual(1500, account.Balance);  
        }

        [Test]
        public void Withdrow_Negativ_Amount_UpdateBalance()
        {
            var account = new BankAccount.BankAccount(1000);

            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdrow(-500));
        }

        [Test]
        public void Transfare_Amount_UpdateBalance()
        {
            var account = new BankAccount.BankAccount(1000);
            var otherAccount = new BankAccount.BankAccount();

            account.TransferFundsTo(otherAccount,500);

            Assert.AreEqual(1500, account.Balance);
            Assert.AreEqual(500, otherAccount.Balance);
        }
    }
}