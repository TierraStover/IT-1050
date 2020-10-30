using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    //class declaration
    public class BankAccount
    {
        //declare data members or attributes 
        private int accountNumber;
        private string accountHolder;
        private string accountType;
        private double balance;
        public double deposit;
        public double withdraw;

        // I am aware that 5 constructors are not necessary but I wanted to practice the concept
        //create default construtor 
        public BankAccount()
        {

        }

        //create constructor with 1 argument
        public BankAccount(int acctNum)
        {
            accountNumber = acctNum;
        }

        //create constructor with 2 arguments
        public BankAccount(int acctNum, string acctHolder)
        {
            accountNumber = acctNum;
            accountHolder = acctHolder;
        }

        //create constructor with 3 arguments
        public BankAccount(int acctNum, string acctHolder, string acctType)
        {
            accountNumber = acctNum;
            accountHolder = acctHolder;
            accountType = acctType;
        }

        // create constructor with 4 arguments
        public BankAccount(int acctNum, string acctHolder, string acctType, double bal)
        {
            accountNumber = acctNum;
            accountHolder = acctHolder;
            accountType = acctType;
            balance = bal;
        }

        // create properties 
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        public string AccountHolder
        {
            get
            {
                return accountHolder;
            }
            set
            {
                accountHolder = value;
            }
        }

        public String AccountType
        {
            get
            {
                return accountType;
            }
            set
            {
                accountType = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        //define methods
        public double GetBalance()
        {
            return balance;
        }

        public void MakeDeposit(double deposit)
        {
            balance = balance + deposit;
            PrintReceipt("deposits", deposit);
        }

        public void MakeWithdraw(double withdraw)
        {
            balance = balance - withdraw;
            PrintReceipt("withdraws", withdraw);
        }

        public override String ToString()
        {
            return "Account Number:" + accountNumber + "\nAccount Holder:" + accountHolder +
            "\nAccount Type:" + accountType + "\nBalance" + balance;
        }

        public void PrintReceipt(string acctType, double amount)
        {
            Console.WriteLine(AccountHolder + " " + acctType + " " + amount + "\n" + "Remaining balance: " + GetBalance());

        }
    }



    class BankAccountApplication
    {
        public static void Main()
        {

            //create Bank Account object using default constructor
            BankAccount MarshaObject = new BankAccount();
            MarshaObject.AccountNumber = 25467;
            MarshaObject.AccountHolder = "Marsha Brady";
            MarshaObject.AccountType = "Checking";
            MarshaObject.Balance = 1500.00;

            //display Marsha Brady Object
            Console.WriteLine("Account Number:{0}", MarshaObject.AccountNumber);
            Console.WriteLine("Customer:{0}", MarshaObject.AccountHolder);
            Console.WriteLine("Type:{0}", MarshaObject.AccountType);
            Console.WriteLine("Balance:{0:c}", MarshaObject.Balance);

            //create Bank Account Object using a constructor with 4 arguments
            BankAccount DwayneObject = new BankAccount(87624, "Dwayne Wayne", "Savings", 746.23);

            //display Dwayne Wayne Object
            Console.WriteLine("\nAccount Number:{0}\nCustomer:{1}\nType:{2}\nBalance:{3:c}\n", DwayneObject.AccountNumber,
            DwayneObject.AccountHolder, DwayneObject.AccountType, DwayneObject.Balance);

            MarshaObject.MakeDeposit(50.00);
            MarshaObject.MakeDeposit(123.56);
            MarshaObject.MakeWithdraw(475.00);
            DwayneObject.MakeDeposit(262.00);
            DwayneObject.MakeWithdraw(250.00);

            Console.ReadKey();




        }
    }
}
