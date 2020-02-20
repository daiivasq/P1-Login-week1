using System;
using System.Collections.Generic;
using System.Text;

namespace P1Login.Models
{
   public class UserModel
    {
        public string Name { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }
}
