using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    enum TypeOfAccount //customized value type
    {
        Checking,
        Saving,
        CD,
        Loan,
    }

    class Account
    {
        private static int lastAccountNumber = 0;

        #region Properties

        public int AccountNumber { get; }
        public TypeOfAccount AccountType { get; set; }
        public decimal Balance { get; private set; } //just one of them could be private not both
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; }
        #endregion

        #region Constructor

        public Account()
        {
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money in your account
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        #endregion




    }
}
