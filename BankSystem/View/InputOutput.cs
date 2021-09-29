using BankSystem.Controller;
using BankSystem.Model;
using System;
using System.Collections.Generic;

namespace BankSystem.View

    {
    public class InputOutput
        {

        public InputOutput()
            {
            menu();
            }
        public List<User> changeUserRole = new List<User>();

        public List<User> userBank = new List<User>();

        public List<User> usreList()
            {
            userBank.Add(new User
                { UserName = "mathilda",Password = "mathilda123",Balance = 20000,Salary = 380000,Role = "Frontend" });

            userBank.Add(new User
                { UserName = "zia",Password = "zia123",Balance = 10000,Salary = 400000,Role = "Backende" });
            return userBank;
            }
        
        public static int intControllar()
            {
            int check;
            while (!int.TryParse(Console.ReadLine(),out check))             //Kolla om input är inte int så-
                {                                                           //skicka ett medalande att talet är inte int.
                Console.WriteLine("Du har skrivt ett fel input försök igen.");
                }
            return check;
            }

        public void menu()
            {
            var loop = true;
            while (loop)
                {
                Console.WriteLine("Vänligen välja en funktion\n\n" +
                    "[1] Logga in som Admin\n" +
                    "[2] Logga in som User\n" +
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
                    System.Environment.Exit(1);
                    }
                else
                    {
                    intControllar();
                    }
                }
            }

        public void adminLogIn()
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

        public  void userLogIn()
            {
            Console.Write("Usernamn: ");
            string nameChk = Console.ReadLine();
            Console.Write("Lösenord: ");
            string passwordChk = Console.ReadLine();

            for (int i = 0; i < userBank.Count; i++)
                {
                //for (int y = 0; y < account.Count; y++)
                //    {
                    if (userBank[i].UserName != nameChk || userBank[i].Password != passwordChk)
                        {
                        Console.WriteLine("Konto finns inte med");
                        break;
                        }
                    else if (userBank[i].UserName == nameChk || userBank[i].Password == passwordChk)
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
            

        public void adminMenu()
            {
            var admin = new List<Admin>() {
                new Admin(){ UserName = "admin1", Password = "admin1234",Balance = 0, Salary = 50000, Role = "admin" }};

            var loop = true;
            while (loop)
                {
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
                    Controller.Account.createAccount(userBank);

                    }
                else if (userInput == 5)
                    {
                    loop = false;
                    menu();
                    }
                else
                    {
                    intControllar();
                    }
                }
            }

        public void userMenu(string nameChk)
            {
            var userloop = true;
            while (userloop)
                {
                Console.WriteLine("Vänligen välja en funktion\n\n" +
               "[1] Konto Lön Roll\n" +
               "[2] Tabor konto\n" +
               "[3] Byta roll & lön\n" +
               "[4] Logga ut\n");
                var userInput = intControllar();

                if (userInput == 1)
                    {
                    for (int i = 0; i < 1; i++)
                        {
                        Console.WriteLine($"Usernamn:\t{userBank[i].UserName = nameChk}\nKontonummer:\t{userBank[i].AccountNumber}\nLön:\t\t{userBank[i].Salary}\nRoll:\t\t{userBank[i].Role}\n");
                        }
                    }
                else if (userInput == 2)
                    {
                   
                    Account.removeAccount(userBank);
                    menu();
                    }
                else if (userInput == 3)
                    Controller.Account.changeRoleSalary(changeUserRole);

                else if (userInput == 4)
                    {
                    userloop = false;
                    Console.WriteLine("Välkomen åter!");
                    menu();
                    }
                else
                    {
                    intControllar();
                    }
                }
            }

        public void userMenu()
            {
            Console.Write("Ange användares namn: ");
            string name = Console.ReadLine().ToLower();

            for (int i = 0; i < userBank.Count; i++)
                {
                if (userBank[i].UserName != name)
                    {
                    Console.WriteLine(name + " är inte med");
                    break;
                    }
                else if (userBank[i].UserName == name)
                    {
                    Console.WriteLine($"Usernamn:\t {userBank[i].UserName} \nLön:\t {userBank[i].Salary} \nRoll:\t {userBank[i].Role}");
                        }
                
                var loop = true;
                while (loop)
                    {
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
                        changeRoleSalary();
                        }
                    else if (userInput == 2)
                        {
                        Account.removeAccount(userBank);
                        adminMenu();
                        }
                    else if (userInput == 3)
                        {
                        for (int ix = 0; ix < userBank.Count; ix++)
                            {
                            if (userBank[ix].UserName == name)
                                {
                                Console.WriteLine($"Usernamn:\t {userBank[ix].UserName} \nLönsenord \t {userBank[ix].Password}\n");
                                break;
                                }
                            }
                        }
                    else if (userInput == 4)
                        {
                        loop = false;
                        adminMenu();
                        }
                    }
                }
            }

        public void changeRoleSalary()
            {
            Console.Write("Usernamn: ");
            string userName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            for (int ix = 0; ix < changeUserRole.Count; ix++)
                {
                if (changeUserRole[ix].UserName == userName && changeUserRole[ix].Password == password)
                    {
                    Console.WriteLine($"Usernamn:\t {changeUserRole[ix].UserName} \nLön:\t {changeUserRole[ix].Salary} \nRoll:\t {changeUserRole[ix].Role}");
                    Console.WriteLine("\n[1] För att tacka ja" +
                        "\n[2] För att tacka nej");
                    var answer = intControllar();
                    if (answer == 1)
                        {
                        Console.WriteLine("Du har tackat ja");

                        }
                    else if (answer == 1)
                        {
                        Console.WriteLine("Du har tackat nej");
                        }
                    else
                        {
                        intControllar();
                        }

                    }
                }
            }
        }
    }