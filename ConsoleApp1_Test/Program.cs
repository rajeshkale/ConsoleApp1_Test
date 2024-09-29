using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Test
{
    class Program
    { //Comment added from git

        //Changes from test Branch 2 
        // Changes comming from Git
        // This code comming from Git
       
        static void Main(string[] args)
        {
            Animal obj= new Pig();
            obj.animalSound();
            Animal obj2= new Pig();
            obj2.animalSound();
            Console.ReadLine();
        }
    }
    class Animal
    {
        // Abstract method (does not have a body)
        public virtual void animalSound()
        {
            Console.WriteLine("Animal Sound");
        }
        // Regular method
        public void sleep()
        {
            Console.WriteLine("animal sleep");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }

        public void sleep()
        {
            Console.WriteLine("Pig Sleeped");
        }
    }
}
