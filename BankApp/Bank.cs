using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    static class Bank //shared class. nothing can be instantiated in this class. oNLY 1 INSTANCE OF THS CLASS IS CREATED
    {
        /// <summary>
        /// Create an account with the Bank
        /// </summary>
        /// <param name="emailAddress">email of the account</param>
        /// <param name="accountType">Type of account</param>
        /// <param name="initialAmount">Initial deposit</param>
        /// <returns>Newly Created Account</returns>
        public static Account CreateAccount(string emailAddress, TypeOfAccount accountType = TypeOfAccount.Checking, decimal initialAmount = 0)
        {
            var account = new Account
            {
                EmailAddress = emailAddress,
                AccountType = accountType,
            };
            if (initialAmount > 0)
            {
                account.Deposit(initialAmount);
            }
            return account;
        }
    }
}
