﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Model
    {
    public class Admin
        {
        public string UserName { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public double Salary { get; set; }
        public string Role { get; set; }

        public static List<Admin> adminBank = new List<Admin>();
        }
    }
