using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankSystem.Controller
    {
    public class Account
        {
        /// <summary>
        /// Creating new accounts
        /// </summary>
        /// <param name="newList"> List av userBank that have accounts </param>
        public static void createAccount(List<User> newList)
            {
            var list = new[] { "~","`","!","@","#","$","%","^","&","*","(",")","+","=" };
            var massege = 0;

            Console.Write("Usernamn: ");
            string userName = Console.ReadLine().ToLower();
            Console.Write("Password: ");
            string password = Console.ReadLine().ToLower();
            Console.Write("Rolle: ");
            string role = Console.ReadLine().ToLower();
            Console.Write("Lön: ");
            double salary = InputsController.inputDoubleControllar();
            Console.Write("Kotonummer: ");
            int accoundNumber = InputsController.inputIntControllar();

            for (int i = 0; i < newList.Count; i++)
                {
                if (newList[i].UserName == userName || newList[i].AccountNumber == accoundNumber)
                    { massege = 1; break; }
                else if (!userName.Any(Char.IsLetter) || !userName.Any(Char.IsDigit) ||
                         !password.Any(Char.IsLetter) || !password.Any(Char.IsDigit))
                    { massege = 2; break; }
                else if (list.Any(userName.Contains) || list.Any(password.Contains))
                    { massege = 3; break; }
                }

            if (massege == 0)
                {
                newList.Add(new User { UserName = userName,Password = password,Role = role,Salary = salary,AccountNumber = accoundNumber });
                Console.WriteLine("Konto har skapat");
                }
            else if (massege == 1)
                { Console.WriteLine("Username eller Kontonummer finns med."); }
            else if (massege == 2)
                { Console.WriteLine("Username och password måste bestå av både text och siffror."); }
            else if (massege == 3)
                { Console.WriteLine("Username och password ska inte hålla tecken."); }
            }

        /// <summary>
        /// Remove the accounts
        /// </summary>
        /// <param name="newList"> List av userBank that have accounts </param>
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
                Console.WriteLine("Fel username eller password!");
                }
            }

        /// <summary>
        /// To pay the salary for users
        /// </summary>
        /// <param name="salaryList"> List av userBank that have accounts </param>
        public static void Salary(List<User> salaryList)
            {
            Console.Write("Ange usernamn: ");
            var name = Console.ReadLine();
            Console.Write("Ange kontonummer: ");
            var account = InputsController.inputIntControllar();
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