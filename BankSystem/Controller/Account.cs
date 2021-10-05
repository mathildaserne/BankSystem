using BankSystem.View;
using BankSystem.Model;
using BankSystem.Controller;
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
            double salary = InputsController.inputDoubleControllar();
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
            var loop = true;
            for (int i = 0; i < newList.Count; i++)
                {
                if (newList[i].UserName == userName && newList[i].Password == password)
                    {
                    newList.RemoveAt(i);
                    Console.WriteLine("Konto är borta");
                    loop = false;
                    }
                }
            if (loop)
                {
                Console.WriteLine("User finns inte med");
                }
            }
        public static void Salary(List<User> salaryList)
            {
            Console.Write("Ange usernamn: ");
            var name = Console.ReadLine();
            Console.Write("Ange kontonummer: ");
            var account = (Console.ReadLine());
            Console.Write("Ange lön: ");
            double salary = InputsController.inputDoubleControllar();
            var loop = true;

            for (int i = 0; i < salaryList.Count; i++)
                {
                if (salaryList[i].UserName == name && salaryList[i].AccountNumber == account && salaryList[i].Salary == salary)
                    {
                    var total = salaryList[i].Balance + salary;
                    salaryList[i].Balance = total;
                    Console.WriteLine($"{name}s lön är betalat...");
                    loop = false;
                    }
                }
            if (loop)
                {
                Console.WriteLine("Fel införmation.");
                }
            }
        }
    }
