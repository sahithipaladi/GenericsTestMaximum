using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics_Test_Maximum;
namespace unittest
{
    [TestClass]
    public class UnitTest1
    {
        //TC1.1
        [TestMethod]
        public void TestMethod1()
        {
   
            
                //Max Number at 1st Position
                float firstValue = 30.5f, secondValue = 20.5f, thirdValue = 10.5f;
                float expected = 30.5f;
                FindMaximum find = new FindMaximum();
                float actual = find.MaximumValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestMethod2()
            {
                //Max Number at 2nd Position
                float firstValue = 20.5f, secondValue = 30.5f, thirdValue = 10.5f;
                float expected = 30.5f;
                FindMaximum find = new FindMaximum();
                float actual = find.MaximumValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestMethod3()
            {
                //Max Number at 3rd Position
                float firstValue = 20.5f, secondValue = 10.5f, thirdValue = 30.5f;
                float expected = 30.5f;
                FindMaximum find = new FindMaximum();
                float actual = find.MaximumValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expected, actual);
            }


        }
    }
