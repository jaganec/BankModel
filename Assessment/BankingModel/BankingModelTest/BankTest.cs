using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingModel;
using Moq;

namespace BankingModelTest
{
    [TestClass]
    public class BankTest
    {
      
        [TestMethod]
        [Description("On Transfer debit and credit happens in both account")]
        public void MoneyTransfer_AddRemove_Defined()
        {
            Mock<IAccount> _mockAccount = new Mock<IAccount>();
            Mock<IAccount> _mockTransferAccount = new Mock<IAccount>();
            
            var bank = new Bank(_mockAccount.Object, _mockTransferAccount.Object);
             bank.MoneyTransfer(It.IsAny<decimal>());

            _mockAccount.Verify(m => m.RemoveMoney(0), Times.Once());
            _mockTransferAccount.Verify(m => m.AddMoney(It.IsAny<decimal>()), Times.Once());

        }

    }
}
