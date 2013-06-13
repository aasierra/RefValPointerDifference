using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValPionter
{
    class Program
    {
        class Car
        {
            public int something;
            public void ChangeCar(Car theCar)
            {
                theCar = new Car();
                theCar.something = 2;
            }
        }
        static void Main(string[] args)
        {
            Car temp = new Car();
            temp.something = 1;
            temp.ChangeCar(temp);
            Console.WriteLine(temp.something);
            Console.Read();
        }

    }
}
