using tyuiu.cources.programming.interfaces.Sprint1;

//
//              x                  2
//            y              sin(x) + cos(y)
// z = ---------------- + --------------------- * tg(xy)
//        cos(x) - x         cos(x) - sin(y)
//                 -
//                 3
//

namespace Tyuiu.IvanovaEA.Sprint1.Task7.V21.Lib
{
    public class DataService : ISprint1Task7V21
    {
        public double Calculate(double x, double y)
        {
            double result = (Math.Pow(y, x) / (Math.Cos(x) - x / 3.0)) + ((Math.Sin(Math.Pow(x, 2)) + Math.Cos(y)) 
                / (Math.Cos(x) - Math.Sin(y)) * Math.Tan(x * y));

            return Math.Round(result, 3);
        }
    }
}
