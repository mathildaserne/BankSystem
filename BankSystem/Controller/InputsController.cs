using System;

namespace BankSystem.Controller
    {
    internal class InputsController
        {
        public static double inputDoubleControllar()
            {
            double check;
            while (!double.TryParse(Console.ReadLine(),out check))
                {
                Console.WriteLine("Du har skrivt ett fel input försök igen.");
                }
            return check;
            }

        public static int inputIntControllar()
            {
            int check;
            while (!int.TryParse(Console.ReadLine(),out check))
                {
                Console.WriteLine("Du har skrivt ett fel input försök igen.");
                }
            return check;
            }
        }
    }