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
                //Arrange
                float firstValue = 25.5f, secondValue = 30.5f, thirdValue = 40.5f
                float expected = 40.5f;
               //Act
                FindMaximum find = new FindMaximum();
                float actual = find.MaximumValue(firstValue, secondValue, thirdValue);
               //Assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestMethod2()
            {
                //Max Number at 2nd Position
                float firstValue = 25.5f, secondValue = 30.5f, thirdValue = 40.5f;
                float expected = 40.5f;
                FindMaximum find = new FindMaximum();
                float actual = find.MaximumValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestMethod3()
            {
                //Max Number at 3rd Position
                float firstValue = 25.5f, secondValue = 30.5f, thirdValue = 40.5f;
                float expected = 40.5f;
                FindMaximum find = new FindMaximum();
                float actual = find.MaximumValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expected, actual);
            }


        }
    }
