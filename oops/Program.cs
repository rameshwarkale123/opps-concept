using System;
using System.Runtime.InteropServices;

namespace opps
{
    public class cal
    {
        // class and obj 

        int num1;
        int num2;
        int result;

        void add()
        {
            result = num1+ num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        void sub()
        {
            result = num1 - num2;    
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            System.Console.WriteLine("calculation");
            cal obj = new cal ();
            obj.num1 = 12;
            obj.num2 = 13;
            obj.add();
            obj.sub ();
        }
    }
}