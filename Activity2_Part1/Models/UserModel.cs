using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Activity2_Part1.Models
{
    public class UserModel
    {

        public string Name { get; set; } 
        public string Email { get; set; }
        public string Phone { get; set; }



        public UserModel(string Name, string Email, string Phone) { 
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
        }



    }
}