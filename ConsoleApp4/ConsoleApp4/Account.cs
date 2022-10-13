using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Account
    {
        public void Login(string username, string password)
        {
            if(IsCorrect(username,password))
            {
                Console.WriteLine("giris ugurludur");
            }
            else
            {
                Console.WriteLine("email ve ya password sehvdir");
            }
        }

        public bool IsCorrect(string a,string b)
        {
            if(a=="Cavid123" && b == "Cavid1993")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

