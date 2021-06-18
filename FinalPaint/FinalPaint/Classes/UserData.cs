using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
    class UserData
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private static List<UserData> users = new List<UserData>();

        private UserData(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
        public static void AddUser(string firstName, string lastName, string email, string password)
        {
            users.Add(new UserData(firstName,lastName, email, password));
        }
        
    }
}
