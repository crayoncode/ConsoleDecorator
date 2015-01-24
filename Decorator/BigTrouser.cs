﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class BigTrouser:Finery
    {
        public override void Show()
        {
            Console.WriteLine("垮裤");
            base.Show();
        }
    }
}
