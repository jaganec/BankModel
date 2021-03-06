﻿using System;

namespace BankingModel
{
    public class Account : IAccount
    { 

        public Account(int accountID, string accountType, string ownerName)
        {
            if (string.IsNullOrWhiteSpace(ownerName))
                throw new ArgumentException("Owner Name Should Not Be Empty", "ownerName");
            if (accountType.GetType().IsEnum)
                throw new ArgumentException("Invalid Account Type", "accountType");

            AccountID = accountID;
            AccountType = accountType;
            OwnerName = ownerName;
        }

        /// <summary>
        /// Gets or Sets Account ID
        /// </summary>
        public int AccountID { get; set; }

        /// <summary>
        /// Gets or Sets OwnerName
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Get or Set AccountType
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// Get or Set Money
        /// </summary>
        public decimal Money { get; set; }

       
        /// <summary>
        /// Debits Money from the Account
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public bool RemoveMoney(decimal money)
        {
            if (this.Money >= money)
            {
                if (Enum.GetName(typeof(AccountTypes), 3) == this.AccountType && money > 1000)
                    return false;
                this.Money -= money;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Credits Money to the Account
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public bool AddMoney(decimal money)
        {
            this.Money += money;
            return true;
        }
    }
}
