using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public interface IBank
    {
       // IAccount SelectAccount(int accountID);
        bool MoneyDeposit( decimal money);

        bool MoneyWithdraw(decimal money);

        void MoneyTransfer( decimal money);
    }
}
