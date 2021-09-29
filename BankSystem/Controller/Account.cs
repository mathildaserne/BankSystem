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


        public void userList(List<User> myList)
            {

            myList.Add(new User
                { UserName = "mathilda",Password = "mathilda123",Balance = 20000,Salary = 380000,AccountNumber = "1212-1",Role = "Frontend" });

            myList.Add(new User
                { UserName = "zia",Password = "zia123",Balance = 10000,Salary = 400000,AccountNumber = "1212-2",Role = "Backende" });

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
    
    public static void changeRoleSalary(List<User> changeList)
        {
        Console.Write("Usernamn: ");
        string userName = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        Console.WriteLine("Role som du vill byta till");
        string role = Console.ReadLine();
        Console.WriteLine("Lön som du vill byta till");
        double salary = double.Parse(Console.ReadLine());

        changeList.Add(new User()
            { UserName = userName,Password = password,Salary = salary,Role = role });
        }
    }
    }
