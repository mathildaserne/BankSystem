using System;
using System.Collections.Generic;
using System.Text;
using BankSystem.Model;

namespace BankSystem.Controller
    {
    public class Account
        {
        public static void createAccount()
            {
            Console.Write("Usernamn: ");
            string userName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Rolle: ");
            string role = Console.ReadLine();
            Console.Write("Lön: ");
            double salary = double.Parse(Console.ReadLine());

            User.userBank.Insert(0,
                new User() { UserName = userName,Password = password,Salary = salary,Role = role });
            }

        public List<User> userList()
            {
            User.userBank.Add(new User()
                { UserName = "zia",Password = "zia123",Balance = 10000,Salary = 400000,Role = "Backende" });
            User.userBank.Add(new User()
                { UserName = "mathilda",Password = "mathilda123",Balance = 1000,Salary = 380000,Role = "Frontend" });
            return User.userBank;
            }

        public static void removeAccount()
            {
            Console.Write("Usernamn: ");
            string userName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            User.userBank.Remove(new User() { UserName = userName,Password = password });
            Console.WriteLine("Konto är borta");
            }

        public static void salary()
            {

            }

        public static void changeRoleSalary()
            {

            }
        }
    }
