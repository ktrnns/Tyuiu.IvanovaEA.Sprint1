using Tyuiu.IvanovaEA.Sprint1.Task6.V16.Lib;

namespace Tyuiu.IvanovaEA.Sprint1.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString ()
        {
            DataService ds = new DataService();

            string strTest = "1 ! ?";

            bool res = ds.CheckSpecSymbols(strTest);

            Assert.IsTrue(res);
        }
    }
}
