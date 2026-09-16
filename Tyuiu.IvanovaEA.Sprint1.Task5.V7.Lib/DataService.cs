using tyuiu.cources.programming.interfaces.Sprint1;

//Написать программу, которая решает следующую задачу:
//Определить h – полное количество часов прошедших от начала суток до того момента (в первой половине дня), 
//когда часовая стрелка повернулась на f градусов (0<f<360, f – вещественное число).

namespace Tyuiu.IvanovaEA.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            // 1 час = 30 градусов (360/12 = 30)
            int h = (int)(f / 30);
            return h;
        }
    }
}
