using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public interface IBank
    {

        void MoneyDeposit(int accountID, decimal money);

        bool MoneyWithdraw(int accountID, decimal money);

        void MoneyTransfer(int accountID, decimal money, int transferAccount);
    }
}
