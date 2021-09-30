using BankSystem.Model;
using System;
using System.Collections.Generic;

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

            for (int i = 0; i < newList.Count; i++)
                {
                if (newList[i].UserName == userName && newList[i].Password == password)
                    {
                    newList.RemoveAt(i);
                    }
                }

            Console.WriteLine("Konto är borta");
            }

        public static void salary(List<User> salaryList)
            {
            Console.Write("Ange namn på insättaren: ");
            var name = Console.ReadLine();
            Console.Write("Ange kontonummer: ");
            var account = (Console.ReadLine());
            Console.Write("Ange insättningsbelopp: ");
            var dep = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < salaryList.Count; i++)
                {
                if (salaryList[i].UserName == name && salaryList[i].AccountNumber == account)
                    {
                    var total = salaryList[i].Balance + dep;
                    salaryList[i].Balance = total;
                    }
                }
            }
        }
    }