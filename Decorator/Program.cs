using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("小明");

            TShits ts = new TShits();
            BigTrouser bt = new BigTrouser();

            ts.Decorate(person);
            bt.Decorate(ts);
            bt.Show();

            Console.ReadKey();
        }
    }
}
