using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("小明");
            TShirts f1 = new TShirts();
            BigTrouser f2 = new BigTrouser();

            f1.Show();
            f2.Show();
            person.Show();

            Console.ReadKey();
        }
    }
}
