using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public class BankDetails
    {
        private List<IAccount> _lstAccount;

        public static string BankName = "xxx";

        public IAccount SelectAccount(int accountID)
        {
            return _lstAccount.SingleOrDefault(x => x.AccountID == accountID);
        }

        public int CreateAccount(string ownerName, string accountType)
        {
            IAccount x = new Account(_lstAccount.Count() + 1, accountType, ownerName);

            _lstAccount.Add(x);

            return x.AccountID;
        }

        public void RemoveAccount(int accountID)
        {
            _lstAccount.Remove(SelectAccount(accountID));

        }

    }
}
