using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public class Bank : IBank
    {
        private List<IAccount> _lstAccount;

        public static string BankName = "xxx";

        private readonly IAccount _account;
        private readonly IAccount _transferaccount;
        public Bank(IAccount account, IAccount transferAccount)
        {
            _account = account;
            _transferaccount = transferAccount;
        }
       
        public bool MoneyDeposit(decimal money)
        {

            return _account.AddMoney(money);

        }

        public bool MoneyWithdraw(decimal money)
        {            

            return _account.RemoveMoney(money);
        }

        public void MoneyTransfer( decimal money)
        {
            _account.RemoveMoney(money);

            _transferaccount.AddMoney(money);
        }
    }
}
