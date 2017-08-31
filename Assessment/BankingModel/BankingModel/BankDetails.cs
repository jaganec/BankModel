using System.Collections.Generic;
using System.Linq;

namespace BankingModel
{
    public static class BankDetails 
    {
        private static List<IAccount> _lstAccount;

        public const string BankName = "xxx" ;

        public static IAccount SelectAccount(int accountID)
        {
            return _lstAccount.SingleOrDefault(x => x.AccountID == accountID);
        }

        //public int CreateAccount(string ownerName, string accountType)
        //{
        //    IAccount x = new Account(_lstAccount.Count() + 1, accountType, ownerName);

        //    _lstAccount.Add(x);

        //    return x.AccountID;
        //}

        //public void RemoveAccount(int accountID)
        //{
        //    _lstAccount.Remove(SelectAccount(accountID));

        //}

    }
}
