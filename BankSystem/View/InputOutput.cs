using BankSystem.Controller;
using BankSystem.Model;
using System;
using System.Collections.Generic;

namespace BankSystem.View

    {
    public class InputOutput
        {
        public List<User> changeUserRoleSalary = new List<User>();
        public List<User> userBank = new List<User>();

        public InputOutput()
            {
            userBank.Add(new User
                { UserName = "mathilda",Password = "mathilda123",Balance = 20000,Salary = 380000,Role = "Frontend",AccountNumber = "1212-1" });
            userBank.Add(new User
                { UserName = "zia",Password = "zia123",Balance = 10000,Salary = 400000,Role = "Backende",AccountNumber = "1212-2" });
            menu();
            }

        public int inputIntControllar()
            {
            int check;
            while (!int.TryParse(Console.ReadLine(),out check))
                {
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
                var userInput = inputIntControllar();

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
                    inputIntControllar();
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

        public void userLogIn()
            {
            Console.Write("Usernamn: ");
            string nameChk = Console.ReadLine();
            Console.Write("Lösenord: ");
            string passwordChk = Console.ReadLine();

            for (int i = 0; i < userBank.Count; i++)
                {

                if (userBank[i].UserName != nameChk || userBank[i].Password != passwordChk)
                    {
                    Console.WriteLine("Konto finns inte med");
                    }
                else if (userBank[i].UserName == nameChk && userBank[i].Password == passwordChk)
                    {
                    Console.Clear();
                    Console.WriteLine("Välkomen " + nameChk);
                    userMenu(nameChk,passwordChk);
                    }
                else
                    {
                    inputIntControllar();
                    }
                }
            }

        public void adminMenu()
            {
            var admin = new List<Admin>(){
              new Admin(){ UserName = "admin1", Password = "admin1234", AccountNumber = "123-123", Balance = 0, Salary = 50000, Role = "admin" }};

            var loop = true;
            while (loop)
                {
                Console.WriteLine("\nVänligen välja en funktion\n\n" +
                       "[1] Kontonummer Saldo Lön Role\n" +
                       "[2] Aktuella användare lösenord\n" +
                       "[3] Betala lön\n" +
                       "[4] Skapa ett nytt kont\n" +
                       "[5] Logga ut\n");
                var userInput = inputIntControllar();

                if (userInput == 1)
                    {
                    foreach (var item in admin)
                        {
                        Console.WriteLine($"Kontonummer: \t{item.AccountNumber}\nSaldo:\t\t {item.Balance} " +
                                          $"\nLön:\t\t {item.Salary} \nRoll:\t\t {item.Role}");
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
                    inputIntControllar();
                    }
                }
            }

        public void userMenu(string nameChk,string passwordChk)
            {
            var userloop = true;
            while (userloop)
                {
                Console.WriteLine("\nVänligen välja en funktion\n\n" +
               "[1] Kontonummer & Saldo\n" +
               "[2] Lön & Roll\n" +
               "[3] Byta roll & lön\n" +
               "[4] Tabor konto\n" +
               "[5] Logga ut\n");
                var userInput = inputIntControllar();

                if (userInput == 1)
                    {
                    for (int i = 0; i < userBank.Count; i++)
                        {
                        if (userBank[i].UserName == nameChk && userBank[i].Password == passwordChk)
                            {
                            Console.WriteLine($"Kontonummer: \t{userBank[i].AccountNumber}\nSaldo: \t\t{userBank[i].Balance}");
                            }
                        }
                    }
                else if (userInput == 2)
                    {
                    for (int i = 0; i < userBank.Count; i++)
                        {
                        if (userBank[i].UserName == nameChk && userBank[i].Password == passwordChk)
                            {
                            Console.WriteLine($"Lön:\t\t{userBank[i].Salary}\nRoll:\t\t{userBank[i].Role}");
                            }
                        }
                    }
                else if (userInput == 3)
                    {
                    Console.Write("Ny roll: ");
                    string role = Console.ReadLine();
                    Console.Write("Nytt lön: ");
                    double salary = double.Parse(Console.ReadLine());
                    changeUserRoleSalary.Add(new User()
                        { UserName = nameChk,Password = passwordChk,Role = role,Salary = salary });
                    }
                else if (userInput == 4)
                    {
                    userBank.Remove(new User() { UserName = nameChk,Password = passwordChk });
                    Console.WriteLine("Konto är borta");

                    //Account.removeAccount(userBank);
                    menu();
                    }
                else if (userInput == 5)
                    {
                    userloop = false;
                    Console.WriteLine("Välkomen åter!");
                    menu();
                    }
                }
            }

        public void userMenu()
            {

            for (int ix = 0; ix < userBank.Count; ix++)
                {
                Console.WriteLine($"Usernamn:\t {userBank[ix].UserName} \nLönsenord \t {userBank[ix].Password}\n");
                }
            var loop = true;
            while (loop)
                {
                Console.WriteLine("\nVänligen välja en funktion\n\n" +
                           "[1] Se begäran \n" +
                           "[2] Ta bort konto \n" +
                           "[3] Start meny \n");
                var userInput = inputIntControllar();

                if (userInput == 1)
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
                    loop = false;
                    adminMenu();
                    }
                }
            }

        public void changeRoleSalary()
            {
            Console.Write("Usernamn: ");
            string userChk = Console.ReadLine();
            Console.Write("Password: ");
            string passwordChk = Console.ReadLine();

            for (int ix = 0; ix < changeUserRoleSalary.Count; ix++)
                {

                if (changeUserRoleSalary[ix].UserName == userChk && changeUserRoleSalary[ix].Password == passwordChk)
                    {
                    Console.WriteLine($"Usernamn:\t {changeUserRoleSalary[ix].UserName} \n" +
                                      $"Lön:\t {changeUserRoleSalary[ix].Salary} \n" +
                                      $"Roll:\t {changeUserRoleSalary[ix].Role}");

                    Console.WriteLine("\n[1] För att tacka ja" +
                                      "\n[2] För att tacka nej");
                    var answer = inputIntControllar();

                    if (answer == 1)
                        {
                        Console.Write("Salary: ");
                        double salaryChk = double.Parse(Console.ReadLine());
                        Console.Write("Rolle: ");
                        var roleChk = Console.ReadLine();

                        userBank.Add(
                          new User { UserName = userChk,Password = passwordChk,Role = roleChk,Salary = salaryChk });
                        Console.WriteLine("Du har tackat ja");
                        }

                    else if (answer == 2)
                        {
                        changeUserRoleSalary.Remove(new User() { UserName = userChk,Password = passwordChk });
                        Console.WriteLine("Du har tackat nej");
                        }
                    }
                }
            }
        }
    }