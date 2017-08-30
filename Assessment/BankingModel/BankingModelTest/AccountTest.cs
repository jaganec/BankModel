using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingModel;
using System;

namespace BankingModelTest
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        [Description("Empty AccountOwner - should not be able to create account")]
        [ExpectedException(typeof(ArgumentException), "Owner Name Should Not Be Empty")]
        public void Constructor_Exception_InvalidOwnerType()
        {           
            var account = new Account(0,"","");
        }


        [TestMethod]
        [Description("Invalid AccountType - should not be able to create account")]
        [ExpectedException(typeof(ArgumentException), "Owner Name Should Not Be Empty")]
        public void Constructor_Exception_InvalidAccountType()
        {
            var account = new Account(0, "", "");
        }


        [TestMethod]
        [Description("Account construction on valid Owner and Account Type")]
        public void Constructor_ExpectInstantiation()
        {
            var account = new Account(0, "xxx", "IndividualInvestment");
            Assert.IsNotNull(account);
        }

        [TestMethod]
        [Description("Deposit Money success")]
        public void MoneyDeposit_Success()
        {
            decimal expectedMoney = 50.50m;
            var depositAcnt = new Account(1, "test", "IndividualInvestment");
            depositAcnt.AddMoney(expectedMoney);
            Assert.AreEqual(expectedMoney, depositAcnt.Money);
        }


        [TestMethod]
        [Description("Withdrawal Money success")]
        public void MoneyWithDraw_Success()
        {
            decimal expectedMoney = 50.50m;
            var depositAcnt = new Account(1, "test", "IndividualInvestment") { Money = 100.00m };
            depositAcnt.RemoveMoney(49.50m);
            Assert.AreEqual(expectedMoney, depositAcnt.Money);
        }

        [TestMethod]
        [Description("Withdrawal Money greater than 1000 for Individual Investment")]
        public void MoneyWithDraw_Failure_IndividualInvesmentMoneyGreaterThan1000()
        {
            var depositAcnt = new Account(1, "test", "IndividualInvestment");
            bool returnvalue = depositAcnt.RemoveMoney(1000.50m);
            Assert.IsFalse(returnvalue);
        }

        [TestMethod]
        [Description("Check for Over Draft failure")]
        public void MoneyWithDraw_Failure_OverDraft()
        {
            var depositAcnt = new Account(1, "test", "IndividualInvestment");
            bool returnvalue = depositAcnt.RemoveMoney(50.00m);
            Assert.IsFalse(returnvalue);
        }

    }
}
