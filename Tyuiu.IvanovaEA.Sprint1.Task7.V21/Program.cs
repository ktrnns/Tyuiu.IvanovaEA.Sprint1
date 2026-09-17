using Tyuiu.IvanovaEA.Sprint1.Task7.V21.Lib;

// Написать программу, которая вычисляет математическое выражение
// по исходным значениям данных, вводимых пользователем.
    //
    //              x                  2
    //            y              sin(x) + cos(y)
    // z = ---------------- + --------------------- * tg(xy)
    //        cos(x) - x         cos(x) - sin(y)
    //                 -
    //                 3
    //

namespace Tyuiu.IvanovaEA.Sprint1.Task4.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Иванова Е. А. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Иванова Екатерина Александровна | ПИНб-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*               x                  2                                      *");
            Console.WriteLine("*             y              sin(x) + cos(y)                              *");
            Console.WriteLine("* z = ---------------- + --------------------- * tg(xy)                   *");
            Console.WriteLine("*        cos(x) - x         cos(x) - sin(y)                               *");
            Console.WriteLine("*                 -                                                       *");
            Console.WriteLine("*                 3                                                       *");
            Console.WriteLine("***************************************************************************");

            double x;
            double y;

            Console.WriteLine("Введите X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат вычисления: " + ds.Calculate(x, y).ToString("F3"));

            Console.ReadLine();
        }
    }
}