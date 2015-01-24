using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class TShits:Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }
}
