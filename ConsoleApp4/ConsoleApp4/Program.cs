using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "Cavid123";
            string password = "Cavid1993";
            Account account = new Account();
            account.Login(username, password);
        }
    }
}
