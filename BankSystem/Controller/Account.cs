using System;
using System.Collections.Generic;
using System.Text;
using BankSystem.Model;
using BankSystem.View;

namespace BankSystem.Controller
    {
    public class Account
        {
       
        public static void createAccount(List<User> newList)
            {
            Console.Write("Usernamn: ");
            string userName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Rolle: ");
            string role = Console.ReadLine();
            Console.Write("Lön: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Kotonummer: ");
            string accoundNumber = Console.ReadLine();

            newList.Add(
                new User { UserName = userName,Password = password,Role = role,Salary = salary,AccountNumber = accoundNumber });
            }
        public static void removeAccount(List<User> newList)
            {
            Console.Write("Usernamn: ");
            string userName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            newList.Remove(new User() { UserName = userName,Password = password });
            Console.WriteLine("Konto är borta");
            }

        public static void salary()
            {
            Console.Write("Ange namn på insättaren: ");
            var name = Console.ReadLine();
            Console.Write("Ange kontonummer: ");
            var account = (Console.ReadLine());
            Console.Write("Ange insättningsbelopp: ");
            var dep = Convert.ToDouble(Console.ReadLine());

            var user = new User();

            if (user.UserName == name && user.AccountNumber == account)
                {
                var total = user.Balance + dep;
                Console.WriteLine("Insättarens namn: " + name);
                Console.WriteLine("Kontonummer: " + account);
                Console.WriteLine("Totalt saldobelopp på kontot: " + total);
                }
            }
        }
    }
