using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingModel;
using Moq;

namespace BankingModelTest
{
    [TestClass]
    public class BankTest
    {
      
        [TestMethod]
        [Description("Money Transfer Method Defined")]
        public void MoneyTransfer_Defined()
        {
            Mock<IBank> mockBank = new Mock<IBank>();
            Mock<IAccount> mockAccount = new Mock<IAccount>();
            mockBank.Setup(x => x.SelectAccount(It.IsAny<int>())).Returns(mockAccount);



        }

    }
}
