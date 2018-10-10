using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* FIRSTS CLASSES BEFORE CREATE FACTORY
            //Instance - Object
            var account = Bank.CreateAccount("test@test.com", TypeOfAccount.Checking, 800.50M);

            account.Deposit(800.50M);
            account.Withdraw(500.00M);

            Console.WriteLine($"AN: {account.AccountNumber}, Balance: {account.Balance:C}, Email: {account.EmailAddress}");

            var account2 = Bank.CreateAccount("davila@test.com"); //option value 
            var account3 = Bank.CreateAccount("davila@test.com", initialAmount: 500.50M); //the method follow the pattern, so for change the optional value you have to 
                                                                                          //write the name of the parameter and set the value.  You don't need to set all of the paremeters. 
            Console.WriteLine($"AN: {account2.AccountNumber}, Balance: {account2.Balance:C}, Email: {account2.EmailAddress}");
            */

            Console.WriteLine("***************************");
            Console.WriteLine("Welcome to my Bank");
            Console.WriteLine("***************************");
            Console.WriteLine("0 Exit");
            Console.WriteLine("1. Create an Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Print all Accounts"); //WriteLine: write the whole thing and go to the next line
            Console.Write("Please select an option: ");   //Write: will write andd stay in the same place          
            var option = Console.ReadLine();            //ReadLine: blinks on the screen, wait till the user input presses the enter key and get the value and save it into a variable option

            switch (option)
            {
                case "0":
                    return;

                case "1":
                    Console.Write("Email Address: ");
                    var emailAdress = Console.ReadLine();
                    var accountTypes = Enum.GetNames(typeof(TypeOfAccount));

                    for (var i = 0; i < accountTypes.Length; i++)
                    {
                        Console.WriteLine($"{i+1}. {accountTypes[i]}");
                    }
                    Console.Write("Select an account type: ");
                    var accountTypeOption = Console.ReadLine();
                    break;
               

            }



        }
    }
}
