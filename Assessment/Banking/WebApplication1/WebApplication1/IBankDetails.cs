using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public interface IBankDetails
    {
         
        IAccount SelectAccount(int accountID);

        int CreateAccount(string ownerName, string accountType);

        void RemoveAccount(int accountID);
    }
}
