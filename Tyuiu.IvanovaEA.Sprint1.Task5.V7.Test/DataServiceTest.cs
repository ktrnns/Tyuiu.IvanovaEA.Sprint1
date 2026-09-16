using Tyuiu.IvanovaEA.Sprint1.Task5.V7.Lib;

//Написать программу, которая решает следующую задачу:
//Определить h – полное количество часов прошедших от начала суток до того момента (в первой половине дня), 
//когда часовая стрелка повернулась на f градусов (0<f<360, f – вещественное число).

namespace Tyuiu.IvanovaEA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double f = 135.0;

            int res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(4, res);
        }
    }
}
