using System;

namespace AtmApp
{
    class AtmApp
    {
        static void Main(string[] args)
        {
            int option;
            int accountBalance = 0;
            int walletBalance = 0;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to Atm!");
                Console.WriteLine("1. Add Balance");
                Console.WriteLine("2. Show Account Balance");
                Console.WriteLine("3. Show Wallet Balance");
                Console.WriteLine("4. Deposit Money");
                Console.WriteLine("5. Withdraw Money");
                Console.WriteLine("6. Exit");
                Console.Write("Enter option: ");
            
                option = Convert.ToInt32(Console.ReadLine());

                switch (option) 
                {
                    case 1:
                        AddBalance();
                        break;
                    case 2:
                        ShowAccountBalance();
                        break;
                    case 3:
                        ShowWalletBalance();
                        break;
                    case 4:
                        DepositMoney();
                        break;
                    case 5:
                        WithDrawMoney();
                        break;
                    case 6:
                        Console.WriteLine("Exited program!");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            } while (option != 6);

            void AddBalance()
            {
                Console.Write("Enter Balance: ");
                int depositAmount = Convert.ToInt32(Console.ReadLine());
                accountBalance += depositAmount; 
                Console.WriteLine("Money added to balance.");
            }

            void ShowAccountBalance()
            {
                Console.WriteLine("Account balance: " + accountBalance);
            }

            void ShowWalletBalance()
            {
                Console.WriteLine("Wallet balance: " + walletBalance);
            }

            void DepositMoney()
            {
                Console.Write("Enter the amount you would like to deposit: ");
                int depositAmount = Convert.ToInt32(Console.ReadLine());

                if (depositAmount > walletBalance)
                {
                    Console.WriteLine("Insufficient wallet balance. Deposit wasn't completed.");
                }
                else
                {
                    accountBalance += depositAmount;
                    walletBalance -= depositAmount;  
                    Console.WriteLine("Deposit was successful!");
                }
            }

            void WithDrawMoney()
            {
                Console.Write("Enter the amount you would like to withdraw: ");
                int withdrawalAmount = Convert.ToInt32(Console.ReadLine());

                if (withdrawalAmount > accountBalance)
                {
                    Console.WriteLine("Insufficient account balance. Withdrawal wasn't completed.");
                }
                else
                {
                    accountBalance -= withdrawalAmount; 
                    walletBalance += withdrawalAmount;
                    Console.WriteLine("Withdrawal was successful!");
                }
            }
        }
    }
}

