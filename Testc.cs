using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApplication4
{
    class Testc
    {
        [TestFixture]
        public class TestClass
        {
            [TestCase]
            public void AreaTest1()
            {   // Assemble
                Area o1 = new Area(2.5, 5);
                double expectv = 12.5;

                //Act 
                double actualV = o1.Sarea();
                // Assert
                Assert.AreEqual(expectv, actualV);

            }
            [TestCase]
            public void AreaTest2()
            {   // Assemble
                Tarea tb1 = new Tarea(6, 5);
                double expectedV = 15;
                // act 
                double actualV = 15;
                // Assert

                Assert.AreEqual(expectedV, actualV);

            }



        }



    }
}

