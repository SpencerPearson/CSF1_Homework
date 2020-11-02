using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main()
        {
            Console.WriteLine("Stratton Oakmont Member ATM");
            Console.Title = "Member Login";
            int remaining = 3;
            int attempts = 0;
            bool success = false;
            while (remaining > 0 && success == false)
            {
                Console.Write("Please enter your account number: ");
                string accountNum = Console.ReadLine();
                if (accountNum == "01478963")
                {
                    Console.WriteLine("Acount located! Profile loading. Please wait...");
                    success = true;
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    remaining = 3;
                    attempts = 0;
                    bool pinSuccess = false;
                    while (remaining > 0 && pinSuccess == false)
                    {
                        Console.WriteLine("Welcome, Member Account " + accountNum);
                        Console.Write("Enter your PIN: ");
                        string userPIN = Console.ReadLine();
                        if (userPIN == "123456")
                        {
                            Console.WriteLine("Password accepted. Acces granted!");
                            pinSuccess = true;
                            System.Threading.Thread.Sleep(2000);
                            decimal balance = 875002.36m;
                            bool repeat = true;
                            Console.Clear();
                            do
                            {
                                Console.Title = $"Stratton Oakmont Member Account {accountNum} Balance: {balance:c}";
                                Console.WriteLine("Main Menu: \nB)alance Inquiry \nF)ast Cash " +
                                    "\nW)ithdrawal \nD)eposit \nE)xit");
                                ConsoleKey menuOption = Console.ReadKey(true).Key;
                                Console.Clear();

                                switch (menuOption)
                                {
                                    case ConsoleKey.B:
                                        #region "balance"
                                        Console.WriteLine($"Your balance is {balance:c}. \nPress \"M\" to return to Main Menu, press any other key to exit.");
                                        ConsoleKey returnOption = Console.ReadKey(true).Key;
                                        switch (returnOption)
                                        {
                                            case ConsoleKey.M:
                                                Console.Clear();
                                                break;
                                            default:
                                                Console.WriteLine("Logout successful. Thank you for using Stratton Oakmont ATM!");
                                                repeat = false;
                                                break;

                                        }
                                        
                                        #endregion
                                        break;
                                    case ConsoleKey.F:
                                        #region "fastCash"
                                        Console.WriteLine("Fast Cash Withdrawal amount:" +
                                            "\n1) $20 \n2) $40 \n3) $60 \n4) $100 \n5) $200 \n6) $500");
                                        ConsoleKey fastCashOption = Console.ReadKey(true).Key;
                                        switch (fastCashOption)
                                        {
                                            case ConsoleKey.D1:
                                                balance -= 20;
                                                Console.WriteLine($"$20 has been withdrawn from your account. \nThank you for using Stratton Oakmont ATM!");
                                                repeat = false;
                                                break;
                                            case ConsoleKey.D2:
                                                balance -= 40;
                                                Console.WriteLine($"$40 has been withdrawn from your account. \nThank you for using Stratton Oakmont ATM!");
                                                repeat = false;
                                                break;
                                            case ConsoleKey.D3:
                                                balance -= 60;
                                                Console.WriteLine($"$60 has been withdrawn from your account. \nThank you for using Stratton Oakmont ATM!");
                                                repeat = false;
                                                break;
                                            case ConsoleKey.D4:
                                                balance -= 100;
                                                Console.WriteLine($"$100 has been withdrawn from your account. \nThank you for using Stratton Oakmont ATM!");
                                                repeat = false;
                                                break;
                                            case ConsoleKey.D5:
                                                balance -= 200;
                                                Console.WriteLine($"$200 has been withdrawn from your account. \nThank you for using Stratton Oakmont ATM!");
                                                repeat = false;
                                                break;
                                            case ConsoleKey.D6:
                                                balance -= 500;
                                                Console.WriteLine($"$500 has been withdrawn from your account. \nThank you for using Stratton Oakmont ATM!");
                                                repeat = false;
                                                break;
                                        }
                                        #endregion
                                        break;
                                    case ConsoleKey.W:
                                        #region "Withdrawal"
                                        Console.Write($"Your current balance is {balance:c}. \nEnter withdrawal ammount: $");
                                        decimal withdrawalAmt = Convert.ToDecimal(Console.ReadLine());
                                        balance -= withdrawalAmt;
                                        Console.WriteLine($"Withdrawal success! Your new balance is {balance:c}. \nPress \"M\" to return to Main Menu, press any other key to exit.");
                                        ConsoleKey returnOption2 = Console.ReadKey(true).Key;
                                        switch (returnOption2)
                                        {
                                            case ConsoleKey.M:
                                                Console.Clear();
                                                break;
                                            default:
                                                Console.WriteLine("Logout successful. Thank you for using Stratton Oakmont ATM!");
                                                repeat = false;
                                                break;
                                        }
                                        #endregion
                                        break;
                                    case ConsoleKey.D:
                                        #region "Deposit"
                                        Console.Write($"Your current balance is {balance:c}. \nEnter withdrawal ammount: $");
                                        decimal depositAmt = Convert.ToDecimal(Console.ReadLine());
                                        balance += depositAmt;
                                        Console.WriteLine($"Deposit success! Your new balance is {balance:c}. \nPress \"M\" to return to Main Menu, press any other key to exit.");
                                        ConsoleKey returnOption3 = Console.ReadKey(true).Key;
                                        switch (returnOption3)
                                        {
                                            case ConsoleKey.M:
                                                Console.Clear();
                                                break;
                                            default:
                                                Console.WriteLine("Logout successful. Thank you for using Stratton Oakmont ATM!");
                                                repeat = false;
                                                break;
                                        }
                                        #endregion
                                        break;
                                    case ConsoleKey.E:
                                        #region "exit"
                                        Console.WriteLine("Logout successful. Thank you for using Stratton Oakmont ATM!");
                                        repeat = false;
                                        #endregion
                                        break;
                                }
                            } while (repeat);
                        }

                        else
                        {
                            attempts++;
                            remaining--;
                            Console.WriteLine("PIN not recognized. Please try again.\n{0} failed attempt{1}, {2} attempt{3} remaining.",
                                attempts,
                                attempts == 1 ? "" : "s",
                                remaining,
                                remaining == 1 ? "" : "s");
                        }
                        if (remaining == 0)
                        {
                            Console.WriteLine("Too many failed attempts. Please try again later.");
                        }
                        else
                        {

                        }
                    }
                }

                else
                {
                    attempts++;
                    remaining--;
                    Console.WriteLine("Account number not recognied. {0} failed attempt{1}, {2} attempt{3} remaining.",
                                                                attempts,
                                                                attempts == 1 ? "" : "s",
                                                                remaining,
                                                                remaining == 1 ? "" : "s");

                    if (remaining == 0)
                    {
                        Console.WriteLine("Too many failed attempts. Please try again later.");
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
