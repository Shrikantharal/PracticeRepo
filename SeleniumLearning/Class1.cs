﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning
{
    public class shri
    {
        [Test]
       public  void firstMethod()
        {
            TestContext.Progress.WriteLine("CHeck ");
            TestContext.Progress.WriteLine("Changes Made in Feature branch two");
        }
    }
}