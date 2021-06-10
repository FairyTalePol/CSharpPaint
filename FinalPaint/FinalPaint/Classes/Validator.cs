using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalPaint.Classes
{
   public static class Validator
    {
        private const string _regexFirst_or_LastName = "^[A-Za-z](-?[A-Za-z]{1,14})?-?([A-Za-z]{1,15})?$";
        private const string _regexEmail = "^[0-9A-Za-z]+(.?[0-9A-Za-z]+){2,29}.?[0-9A-Za-z]+@[a-z]+.[a-z]{2,4}$";
        private static Regex _regex;
        public static bool CheckEmail(string email)
        {
            _regex = new Regex(_regexEmail);
            if (email != null)
            {
                bool result = false;
                if (_regex.IsMatch(email))
                {
                    result = true;
                }

                return result;
            }

            throw new ArgumentNullException("Email is null.");
        }

        public static bool CheckFirst_or_LastName(string name)
        {
            _regex = new Regex(_regexFirst_or_LastName);
            if (name != null)
            {
                bool result = false;
                if (_regex.IsMatch(name))
                {
                    result = true;
                }

                return result;
            }

            throw new ArgumentNullException("Name is null.");
        }

        public static bool CheckPassword(string password)
        {
            int passwordMinSize = 6;
            int passwordMaxSize = 30;
            int actualPasswordSize = password.Length;
            if(password!=null)
            {
                bool result = false;
                if(actualPasswordSize>=passwordMinSize&&actualPasswordSize<=passwordMaxSize)
                {
                    result = true;
                }
                return result;
            }
            throw new NullReferenceException("Password is null.");
        }

    }

}

