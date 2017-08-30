using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public  class Bank : IBank
    {      

        public void MoneyDeposit(int accountID,decimal money)
        {
            var depositAcc = SelectAccount(accountID);

            depositAcc.AddMoney(money);
        }

        public bool MoneyWithdraw(int accountID, decimal money)
        {
            var depositAcc = SelectAccount(accountID);

            return depositAcc.RemoveMoney(money);
        }

        public void MoneyTransfer(int accountID, decimal money, int transferAccount)
        {
            MoneyWithdraw( accountID,  money);

            MoneyDeposit(transferAccount,  money);
        }
    }
}
