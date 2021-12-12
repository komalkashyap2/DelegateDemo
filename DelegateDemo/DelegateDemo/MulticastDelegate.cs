using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
     public class MulticastDelegate
    {
        delegate void DelOp(int x, int y);
        public static void ImplementDelegate()
        {
            //Delegate instantiation
            DelOp obj = Operation.Add;
            obj += Operation.Square;
            obj += Operation.Substract;

            obj(5, 5);
            obj(8, 3);

            Console.ReadLine();
        }
        public class Operation
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Addition={0}", a + b);
            }
            public static void Square(int a, int b)
            {
                Console.WriteLine("Multiplication={0}", a * b);
            }
            public static void Substract(int a, int b)
            {
                Console.WriteLine("Substraction={0}", a - b);
            }
        }
    }
}
