using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    //Delegate Defination or Declaration
    public delegate int operation(int x, int y);
      class Program
    {
      
        /// method that is paases as a argument
        ///It has same signature as Delegates
       
       
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static int Substraction(int a, int b)
        {
            return a - b;
        }
        static int Multiplication(int a, int b)
        {
            return a * b;
        }
     
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate POC!!!");

            ///Delegate instantiation
            operation obj = new operation(Addition);
            operation p = new operation(Substraction);
            operation op = new operation(Multiplication);

            ///output
            Console.WriteLine("Addition is={0}", obj(23, 27));
            Console.WriteLine("Substarction is={0}", p(29, 27));
            Console.WriteLine("Multiplication is={0}", op(29, 27));
            Console.WriteLine();


            ///Calling the MulticastDelegate
            MulticastDelegate.ImplementDelegate();
         
        }
    }
}
