using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics_Test_Maximum;
namespace unittest
{
    namespace TestProject
    {
        [TestClass]
        public class UnitTest1
        {

            /// <summary>
            /// TC 1.1 -Maximum Number at first value
            /// </summary>
            [TestMethod]
            public void TestMethod1()
            {
                ///AAA Methodology
                //Arrange
                int[] intArray = { 10, 20, 30 };
                int expected = 30;
                //Act
                MaximumAmongThree<int> max = new MaximumAmongThree<int>(intArray);
                int actual = max.FindMaxValue();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            /// <summary>
            /// TC 1.2 -Maximum Number at second value
            /// </summary>
            [TestMethod]
            public void TestMethod2()
            {
                ///AAA Methodology
                //Arrange
                float[] floatArray = { 10.3f, 20.3f, 30.3f };
                float expected = 30.3f;
                //Act
                MaximumAmongThree<float> max = new MaximumAmongThree<float>(floatArray);
                float actual = max.FindMaxValue();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            /// <summary>
            /// TC 1.3 -MAximum Number at third value
            /// </summary>
            [TestMethod]
            public void TestMethod3()
            {
                ///AAA Methodology
                //Arrange
                string[] strArray = { "Apple", "Banana", "Peach" };
                string expected = "Peach";
                //Act
                MaximumAmongThree<string> max = new MaximumAmongThree<string>(strArray);
                string actual = max.FindMaxValue();
                //Assert
                Assert.AreEqual(expected, actual);

            }



        }
    }
}
    
