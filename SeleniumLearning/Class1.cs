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

            TestContext.Progress.WriteLine("This change is being made in Feature branch two before committing feature branch one");


            TestContext.Progress.WriteLine("After commiting this second commit");

            TestContext.Progress.WriteLine("Changes Made at Feature Two");
            TestContext.Progress.WriteLine("Chnages done before taking latest from master");
        }
    }
}
