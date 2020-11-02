using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main()
        {
            Console.WriteLine("User Login");
            Console.Title = "User Login";
            int remaining = 3;
            int attempts = 0;
            int success = 0;
            while (remaining > 0 && success == 0)
            {
                Console.Write("Enter your username: ");
                string userName = Console.ReadLine().ToLower();
                if (userName == "ogspencerp")
                {
                    Console.WriteLine("Username recognized! Please wait...");
                    success++;
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    remaining = 3;
                    attempts = 0;
                    int pwSuccess = 0;
                    while (remaining > 0 && pwSuccess == 0)
                    {
                        Console.WriteLine("Welcome, " + userName);
                        Console.Write("Enter your password: ");
                        string userPass = Console.ReadLine();
                        if (userPass == "SuperSecretPass9876")
                        {
                            Console.WriteLine("Password accepted. Acces granted!");
                            pwSuccess++;
                        }
                        else
                        {
                            attempts++;
                            remaining--;
                            Console.WriteLine("Password not recognized. Check your login info and try again.\nRemember, passwords are case sensitive.\n {0} failed attempt{1}, {2} attempt{3} remaining.",
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
                    Console.WriteLine("Username not recognied. {0} failed attempt{1}, {2} attempt{3} remaining.",
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