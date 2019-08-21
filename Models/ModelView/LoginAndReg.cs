using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace weddingPlanner.Models
{
    public class LoginAndReg
    {
        public User NewUser {get; set;}

        public Login CheckUser {get; set;}
    }
}