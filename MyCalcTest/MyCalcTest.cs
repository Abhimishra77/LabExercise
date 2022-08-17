using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabExercise;

namespace LabExercise
{
    [TestClass]
    public class MyCalcTest
    {
        
        [DataTestMethod]
        [DataRow(10,20,30)]
        public void TestDataAddmethod(double a1,double a2,double expectedresult)
        {
            double actualresult = MyCalc.Add(a1,a2);
        Assert.AreEqual(expectedresult,actualresult, "add Test Case not passes");
        }
        [DataTestMethod]
        [DataRow(20,30,50)]
        public void TestData3Addmethod(double a1,double a2,double expectedresult)
        {
            double actualresult = MyCalc.Add(a1,a2);
        Assert.AreEqual(expectedresult,actualresult, "add Test Case not passes");
        }
        
        [DataTestMethod]
        [DataRow(30,20,10)]
        public void TestDataSubmethod(double a1,double a2,double expectedresult)
        {
            double actualresult = MyCalc.Sub(a1,a2);
        Assert.AreEqual(expectedresult,actualresult, "sub Test Case not passes");
        }

        [DataTestMethod]
        [DataRow(10,20,200)]
        public void TestDataMulmethod(double a1,double a2,double expectedresult)
        {
            double actualresult = MyCalc.Mul(a1,a2);
            Assert.AreEqual(expectedresult,actualresult, "add Mul Case not passes");
        }
        
        [DataTestMethod]
        [DataRow(20,10,2)]
        public void TestDataDivmethod(double a1,double a2,double expectedresult)
        {
            double actualresult = MyCalc.Div(a1,a2);
            Assert.AreEqual(expectedresult,actualresult, "add Div Case not passes");
        }
        
        [DataTestMethod]
        [DataRow(5,3,125)]
        public void TestDataPowmethod(int a1,int a2,int expectedresult)
        {
            int actualresult = MyCalc.Pow(a1,a2);
            Assert.AreEqual(expectedresult,actualresult, "Pow Test Case not passes");
        }
        [DataTestMethod]
        [DataRow(10,20,40)]
        public void TestData1Addmethod(double a1,double a2,double expectedresult)
        {
            double actualresult = MyCalc.Add(a1,a2);
        Assert.AreNotEqual(expectedresult,actualresult, "add Test Case not passes");
        }
        [DataTestMethod]
        [DataRow(30,20,20)]
        public void TestData1Submethod(double a1,double a2,double expectedresult)
        {
            double actualresult = MyCalc.Sub(a1,a2);
        Assert.AreNotEqual(expectedresult,actualresult, "sub Test Case not passes");
        }

        [DataTestMethod]
        [DataRow(10,20,300)]
        public void TestData1Mulmethod(double a1,double a2,double expectedresult)
        {
            double actualresult = MyCalc.Mul(a1,a2);
            Assert.AreNotEqual(expectedresult,actualresult, "add Mul Case not passes");
        }
        
        [DataTestMethod]
        [DataRow(20,10,4)]
        public void TestData1Divmethod(double a1,double a2,double expectedresult)
        {
            double actualresult = MyCalc.Div(a1,a2);
            Assert.AreNotEqual(expectedresult,actualresult, "add Div Case not passes");
        }
        
        [DataTestMethod]
        [DataRow(5,3,325)]
        public void TestData1Powmethod(int a1,int a2,int expectedresult)
        {
            int actualresult = MyCalc.Pow(a1,a2);
            Assert.AreNotEqual(expectedresult,actualresult, "Pow Test Case not passes");
        }
    
    }
}
