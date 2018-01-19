using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using fitlibrary;
using fitnesse;
using fitSharp;

namespace Acceptance.Tests
{
    class MyAcceptanceTests:ColumnFixture
    {
        public string FirstString;
        public string SecondString;
        public string Concatenate()
        {
            return FirstString + " " + SecondString;
        }
    }
}
