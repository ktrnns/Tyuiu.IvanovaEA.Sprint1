using Tyuiu.IvanovaEA.Sprint1.Task4.V21.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные, 
//    вычисляет результат по формуле и печатает его на экране. 
//    Ответ округлите до 3 знаков после запятой.
//     ( | ( (1 + x)^2 ) - y | ) / (x + y)

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
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Иванова Екатерина Александровна | ПИНб-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Формула: (|((1 + x)^2 ) - y|) / (x + y)                                 *");

            double x;
            double y;

            Console.WriteLine("Введите X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y:");
            y = Convert.ToDouble(Console.ReadLine());

            if (x + y == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат вычисления: " + ds.Calculate(x, y).ToString("F3"));

            Console.ReadLine();
        }
    }
}