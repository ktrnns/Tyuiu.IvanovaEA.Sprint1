using Tyuiu.IvanovaEA.Sprint1.Task7.V21.Lib;

namespace Tyuiu.IvanovaEA.Sprint1.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 8.0;
            double y = 1.0;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(9.705, res);
        }
    }
}
