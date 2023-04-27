
using System;
using System.Xml;

namespace polymorphism
{
   public class Animal
    {
        // condition
        // All the methods should be have same name;
        // all the methods should be in Different class,
        // but method should have same parameters, 
        // there should be inheritance between classes.
        public void Eat()
        {
            Console.WriteLine("Animal is Etting");
        }
    }
   public class Dog:Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is Etting");
        }
    }


    internal class Overloading
    {

        //condition 
        //All the Method shoulds be have same name,
        //All the method shoulds be in same class'
        // But methods shouldhave Different Parameters
        void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        void sum(float a, float b)

        {
            Console.WriteLine (a+ b);
        }


        static void Main(string[] args)
        {
            Overloading obj = new Overloading();    
            obj.sum(1,2);
            Console.ReadLine();

           // Dog tommay= new Dog();
            //tommay.Eat();  
            ///Console.ReadLine(); 
        }
    }
}
