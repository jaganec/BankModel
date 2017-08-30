﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public interface IAccount
    {
        int AccountID { get; set; }
        string OwnerName { get; set; }
        string AccountType { get; set; }
        decimal Money { get; set; }

        bool AddMoney(decimal money);
        bool RemoveMoney(decimal money);
    }
}