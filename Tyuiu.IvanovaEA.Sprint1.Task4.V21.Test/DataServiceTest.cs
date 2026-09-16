using Tyuiu.IvanovaEA.Sprint1.Task4.V21.Lib;

namespace Tyuiu.IvanovaEA.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 6.0;
            double y = 4.0;  

            var res = ds.Calculate(x, y);
            Assert.AreEqual(4.5, res);
        }
    }
}
