﻿namespace BankSystem.Model
    {
    public class User
        {
        public string UserName { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public double Salary { get; set; }
        public int AccountNumber { get; set; }
        public string Role { get; set; }
        }
    }