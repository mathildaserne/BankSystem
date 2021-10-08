﻿using BankSystem.Controller;
using BankSystem.Model;
using System;
using System.Collections.Generic;

namespace BankSystem.View

    {
    public class InputOutput
        {
        public void Logo()
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("========================================================================================================================\n");
            Console.WriteLine("                             * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("                             *  # # # # # # # # # # # # # # # # # # # # # # # # # # #  *");
            Console.WriteLine("                             *  #                                                   #  *");
            Console.WriteLine("                             *  #            Välkommen till BankSystem...           #  *");
            Console.WriteLine("                             *  #                                                   #  *");
            Console.WriteLine("                             *  # # # # # # # # # # # # # # # # # # # # # # # # # # #  *");
            Console.WriteLine("                             * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
            Console.WriteLine("========================================================================================================================\n");
            Console.ForegroundColor = ConsoleColor.White;
            }

        public void displayLogo(string meddelande)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=======================================================================================================================\n");
            Console.WriteLine("                             * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("                             *  # # # # # # # # # # # # # # # # # # # # # # # # # # #  *");
            Console.WriteLine("                             *  #                                                   #  *");
            Console.Write("                             *  #");
            for (int i = 0; i < (51 - meddelande.Length) / 2; i++)
                Console.Write(" ");
            Console.Write(meddelande);
            for (int i = 0; i < (52 - meddelande.Length) / 2; i++)
                Console.Write(" ");
            Console.WriteLine("#  *");
            Console.WriteLine("                             *  #                                                   #  *");
            Console.WriteLine("                             *  # # # # # # # # # # # # # # # # # # # # # # # # # # #  *");
            Console.WriteLine("                             * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine();
            Console.WriteLine("=======================================================================================================================\n");
            Console.ForegroundColor = ConsoleColor.White;
            }

        public List<User> changeUserRoleSalary = new List<User>();
        public List<User> userBank = new List<User>();

        public InputOutput()
            {
            userBank.Add(new User
                { UserName = "mathilda1",Password = "mathilda123",Balance = 20000,Salary = 38000,Role = "Frontend",AccountNumber = 2021 });
            userBank.Add(new User
                { UserName = "zia1",Password = "zia123",Balance = 10000,Salary = 40000,Role = "Backende",AccountNumber = 2022 });
            Logo();
            menu();
            }

        public int menu()
            {
            var loop = true;
            while (loop)
                {
                Console.WriteLine("Vänligen välja en funktion\n\n" +
                    "[1] Logga in som Admin\n" +
                    "[2] Logga in som User\n" +
                    "[3] Stäng programmet");
                var userInput = InputsController.inputIntControllar();

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
                    Console.Clear();
                    displayLogo("Välkommen åter");
                    System.Environment.Exit(1);
                    }
                else
                    {
                    InputsController.inputIntControllar();
                    }
                }
            return menu();
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
                    displayLogo("Välkomen Admin");
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
            string nameChk = Console.ReadLine().ToLower();
            Console.Write("Lösenord: ");
            string passwordChk = Console.ReadLine().ToLower();
            var loop = true;
            for (int i = 0; i < userBank.Count; i++)
                {
                if (userBank[i].UserName == nameChk && userBank[i].Password == passwordChk)
                    {
                    Console.Clear();
                    displayLogo("Välkommen " + nameChk);
                    userMenu(nameChk,passwordChk);
                    loop = false;
                    }
                }
            if (loop)
                {
                Console.WriteLine("Konto finns inte med");
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
                       "[2] Aktuella användare lösenord Roll\n" +
                       "[3] Betala lön\n" +
                       "[4] Skapa ett nytt kont\n" +
                       "[5] Logga ut\n");
                var userInput = InputsController.inputIntControllar();

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
                    Controller.Account.Salary(userBank);
                    }
                else if (userInput == 4)
                    {
                    Controller.Account.createAccount(userBank);
                    }
                else if (userInput == 5)
                    {
                    loop = false;
                    Console.Clear();
                    Logo();
                    menu();
                    }
                else
                    {
                    InputsController.inputIntControllar();
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
               "[4] Tabort konto\n" +
               "[5] Logga ut\n");
                var userInput = InputsController.inputIntControllar();

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
                    double salary = InputsController.inputDoubleControllar();
                    changeUserRoleSalary.Add(new User()
                        { UserName = nameChk,Password = passwordChk,Role = role,Salary = salary });
                    Console.WriteLine("Vänta på svar från Admin.");
                    }
                else if (userInput == 4)
                    {
                    Account.removeAccount(userBank);
                    menu();
                    }
                else if (userInput == 5)
                    {
                    userloop = false;
                    Console.WriteLine("Välkomen åter!");
                    Console.Clear();
                    Logo();
                    menu();
                    }
                }
            }

        public void userMenu()
            {
            for (int ix = 0; ix < userBank.Count; ix++)
                {
                Console.WriteLine($"Usernamn:\t {userBank[ix].UserName} \nLönsenord \t {userBank[ix].Password}\nRoll: \t\t {userBank[ix].Role}\n");
                }
            var loop = true;
            while (loop)
                {
                Console.WriteLine("\nVänligen välja en funktion\n\n" +
                           "[1] Kontonummer Saldo Lön \n" +
                           "[2] Se begäran \n" +
                           "[3] Ta bort konto \n" +
                           "[4] Start meny \n");
                var userInput = InputsController.inputIntControllar();

                if (userInput == 1)
                    {
                    for (int ix = 0; ix < userBank.Count; ix++)
                        {
                        Console.WriteLine($"Username:\t{userBank[ix].UserName}\nKonotonummer:\t{userBank[ix].AccountNumber}\n" +
                                          $"Saldo: \t\t{userBank[ix].Balance}\nLön: \t\t{userBank[ix].Salary}\n");
                        }
                    }
                else if (userInput == 2)
                    {
                    changeRoleSalary();
                    }
                else if (userInput == 3)
                    {
                    Account.removeAccount(userBank);
                    adminMenu();
                    }
                else if (userInput == 4)
                    {
                    loop = false;
                    adminMenu();
                    }
                }
            }

        public void changeRoleSalary()
            {
            Console.Write("Usernamn: ");
            string userChk = Console.ReadLine().ToLower();
            Console.Write("Password: ");
            string passwordChk = Console.ReadLine().ToLower();

            for (int ix = 0; ix < changeUserRoleSalary.Count; ix++)
                {
                if (changeUserRoleSalary[ix].UserName == userChk && changeUserRoleSalary[ix].Password == passwordChk)
                    {
                    Console.WriteLine($"Usernamn:\t {changeUserRoleSalary[ix].UserName} \n" +
                                      $"Lön:\t {changeUserRoleSalary[ix].Salary} \n" +
                                      $"Roll:\t {changeUserRoleSalary[ix].Role}");

                    Console.WriteLine("\n[1] För att tacka ja" +
                                      "\n[2] För att tacka nej" +
                                      "\n[3] För att svara senare");
                    var answer = InputsController.inputIntControllar();

                    if (answer == 1)
                        {
                        Console.Write("Usernamn: ");
                        string name = Console.ReadLine().ToLower();
                        Console.Write("Password: ");
                        string password = Console.ReadLine().ToLower();
                        Console.Write("Salary: ");
                        double salaryChk = InputsController.inputDoubleControllar();
                        Console.Write("Rolle: ");
                        string roleChk = Console.ReadLine().ToLower();

                        for (int i = 0; i < userBank.Count; i++)
                            {
                            if (userBank[i].UserName == name && userBank[i].Password == password)
                                {
                                userBank[i].Salary = salaryChk;
                                userBank[i].Role = roleChk;
                                Console.WriteLine("Du har tackat ja");
                                changeUserRoleSalary.RemoveAt(ix);
                                }
                            }
                        }
                    else if (answer == 2)
                        {
                        Console.WriteLine("Du har tackat nej");
                        changeUserRoleSalary.RemoveAt(ix);
                        }
                    else if (answer == 3)
                        {
                        Console.WriteLine("Du vill svara senare");
                        }
                    }
                }
            }
        }
    }