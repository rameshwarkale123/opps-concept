using System;
using System.Xml.Schema;

namespace inheristance
{
    class car // parent class
    {
        protected string model; //
        protected string color;
        protected int price;

        public void PrintcarInformation()
        {
            System.Console.WriteLine("model:" + model);
            System.Console.WriteLine("color: " + color);
            System.Console.WriteLine("price: " + price);
        } 

       
    }
    class Maruti:car // child class
    {
        float mileage;
        
        void PrintMileage()
        {
            System.Console.WriteLine("Mileage: " + mileage);

        }
        public static void Main(string[] args)

        {
            Maruti myCar = new Maruti();
            myCar.model = "Hyundai";
            myCar.color = "Yellow";
            myCar.price = 1500000;
            myCar.mileage = 15.4f;
            myCar.PrintcarInformation();
            myCar.PrintMileage();
            Console.ReadLine ();    
                
        }



    }

}
