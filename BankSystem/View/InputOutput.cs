using System;
using System.Collections.Generic;
using System.Text;
using BankSystem.Model;
using BankSystem.Controller;
namespace BankSystem.View

    {
    public class InputOutput
        {
        public static List<User> userBank = User.userBank;

        public static int intControllar()
            {
            int check;
            while (!int.TryParse(Console.ReadLine(),out check))             //Kolla om input är inte int så-
                {                                                           //skicka ett medalande att talet är inte int.
                Console.WriteLine("Du har skrivt ett fel input försök igen.");
                }
            return check;
            }

        public static void menu()
            {
            var loop = true;
            while (loop)
                {
                Console.WriteLine("Vänligen välja en funktion\n\n" +
                    "[1] Logga in som Admin\n" +
                    "[2] Logga in som kund\n" +
                    "[3] Stäng programmet");
                var userInput = intControllar();

                if (userInput == 1)
                    {
                    adminLogIn();
                    }
                else if (userInput == 2)
                    {
                    userLogIn();
                    }
                else if (userInput == 3)
                    {
                    loop = false;
                    break;
                    }
                else
                    {
                    intControllar();
                    }
                }
            }

        public static void adminLogIn()
            {
            var userName = "admin1";
            var password = "admin1234";

            Console.Write("Usernamn: ");
            string _userName = Console.ReadLine().ToLower();

            Console.Write("Lösenord: ");
            var _password = Console.ReadLine().ToLower();

            if (_userName == userName)
                {
                if (_password == password)
                    {
                    Console.Clear();
                    Console.WriteLine("Välkomen Admin");
                    adminMenu();
                    }
                else
                    {
                    Console.WriteLine("Fel lösenord försök igen");
                    }
                }
            else
                {
                Console.WriteLine("Fel usernamn försök igen");
                }
            }

        public static void userLogIn()
            {
            Account user = new Account();
            var account = user.userList();

            Console.Write("Usernamn: ");
            string nameChk = Console.ReadLine();
            Console.Write("Lösenord: ");
            string passwordChk = Console.ReadLine();

            for (int i = 0; i < userBank.Count; i++)
                {
                if (!(userBank[i].UserName == nameChk) && !(User.userBank[i].Password == passwordChk))
                    {
                    Console.WriteLine("Konto finns inte med");
                    }
                else if (userBank[i].UserName == nameChk && User.userBank[i].Password == passwordChk)
                    {
                    Console.Clear();
                    Console.WriteLine("Välkomen " + nameChk);
                    userMenu(nameChk);
                    }

                else
                    {
                    intControllar();
                    }
                }
            }

        public static void adminMenu()
            {
            var loop = true;
            while (loop)
                {
                var admin = new List<Admin>() {
                new Admin(){ UserName = "admin1", Password = "admin1234",Balance = 0, Salary = 50000, Role = "admin" }};

                Console.WriteLine("Vänligen välja en funktion\n\n" +
                       "[1] Konto Lön Role\n" +
                       "[2] Användar\n" +
                       "[3] Betala lön\n" +
                       "[4] Skapa ett nytt kont\n" +
                       "[5] Logga ut\n");
                var userInput = intControllar();

                if (userInput == 1)
                    {
                    foreach (var item in admin)
                        {
                        Console.WriteLine($"Saldo:\t {item.Balance} \nLön:\t {item.Salary} \nRoll:\t {item.Role}");
                        }
                    }
                else if (userInput == 2)
                    {
                    userMenu();
                    }
                else if (userInput == 3)
                    {
                    Controller.Account.salary();
                    }
                else if (userInput == 4)
                    {
                    Controller.Account.createAccount();
                    }
                else if (userInput == 5)
                    {
                    loop = false;
                    break;
                    }
                else
                    {
                    intControllar();
                    }
                }
            }

        public static void userMenu(string nameChk)
            {
            var userloop = true;
            Console.WriteLine("Vänligen välja en funktion\n\n" +
               "[1] Konto Lön Roll\n" +
               "[2] Tabor konto\n" +
               "[3] Byta roll & lön\n" +
               "[4] Logga ut\n");
            var userInput = intControllar();

            while (userloop)
                {
                if (userInput == 1)
                    {
                    foreach (var item in userBank)
                        {
                        Console.WriteLine($"Usernamn:\t {item.UserName = nameChk} \nLön:\t\t {item.Salary} \nRoll:\t\t {item.Role}");
                        Console.ReadLine();
                        break;
                        }
                    }
                else if (userInput == 2)
                    {
                    Account.removeAccount();
                    menu();
                    }
                else if (userInput == 3)
                    Controller.Account.changeRoleSalary();
                else if (userInput == 4)
                    {
                    
                    Console.WriteLine("Välkomen åter!");
                    //break;
                    userloop = false;
                    }
                else
                    {
                    intControllar();
                    }
                }
            }

        public static void userMenu()
            {
            Account listAccount = new Account();
            var account = listAccount.userList();

            Console.Write("Ange användares namn: ");
            string name = Console.ReadLine().ToLower();

            for (int i = 0; i < userBank.Count; i++)
                {

                if (userBank[i].UserName == name)
                    {
                    Console.WriteLine($"Usernamn:\t {userBank[i].UserName} \nLön:\t {userBank[i].Salary} \nRoll:\t {userBank[i].Role}");
                    }
                else if (!(userBank[i].UserName == name))
                    {
                    Console.WriteLine(name + " är inte med");
                    adminMenu();
                    }
                //var loop = true;
                //while (loop)
                //{

                Console.WriteLine("Vänligen välja en funktion\n\n" +
                               "[1] Se begäran \n" +
                               "[2] Ta bort konto \n" +
                               "[3] Aktuella användare lösenord \n" +
                               "[4] Start meny \n");
                var userInput = intControllar();
                if (userInput != 1 && userInput != 2 && userInput != 3 && userInput != 4)
                    {
                    intControllar();
                    }
                else if (userInput == 1)
                    {
                    Console.WriteLine("Se begärn");
                    }
                else if (userInput == 2)
                    {
                    Account.removeAccount();
                    adminMenu();
                    }
                else if (userInput == 3)
                    {
                    for (int ix = 0; ix < userBank.Count; ix++)
                        {
                        Console.WriteLine($"Usernamn:\t {userBank[ix].UserName} \nLönsenord \t {userBank[ix].Password}\n");
                        }
                    }

                else if (userInput == 4)
                    {

                    //loop = false;
                    break;
                    //adminMenu();
                    }

                //}
                }
            }
        }
    }


