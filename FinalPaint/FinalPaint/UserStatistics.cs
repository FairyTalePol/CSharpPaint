﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint
{
   public class UserStatistics
    {
        public int Id { get; private set; }
        public int UserId { get; set; }
       // public User User { get; set; }
        public int AmountBMP { get; set; }
        public int AmountJson { get; set; }
        public int AmountJPG { get; set; }
        public int AmountPNG { get; set; }
        public int AmountTotal { get; set; }



        public string RegistrationDate { get; set; }

        public string LastActivity { get; set; }


    }
}

