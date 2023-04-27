using System;

namespace Encapsulation
{
    class Account
    {
        
     int accountBalace = 1000;
        public void SetBalance(int amount)

        {
            if (amount < 0)
            {
                Console.WriteLine("you can not pass negative value");
            }
            else
            {
                accountBalace = amount;
            }
        }
        public void GetBalace()
        {
           Console.WriteLine("your account balace is: "+accountBalace);
        }

    }
    class prog
    {
        static void Main(string[] args)
        {
            Account MyAccount = new Account();
            MyAccount.SetBalance(-100);
            MyAccount.GetBalace();
            Console.ReadLine();
        }
    }
}
