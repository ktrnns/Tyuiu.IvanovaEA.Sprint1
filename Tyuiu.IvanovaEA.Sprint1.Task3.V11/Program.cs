using Tyuiu.IvanovaEA.Sprint1.Task3.V11.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.
//Расчёты:
//Напишите программу, которая вычисляет площадь треугольника, если известны координаты его углов. Ответ округлите до 3 знаков после запятой.
//Введите координаты углов (числа разделяйте пробелом):
//x1-> - 2
//y1-> 5
//х2-> 1
//у2-> 7
//хЗ-> 5
//уЗ-> - 3
//Площадь треугольника: 19 кв.см
// ISprint1Task3V11.TriangleArea(double, double, double, double, double, double)

namespace Tyuiu.IvanovaEA.Sprint1.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Иванова Е. А. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Иванова Екатерина Александровна | ПИНб-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая вычисляет площадь треугольника, если        *");
            Console.WriteLine("* известны координаты его углов. Ответ округлите до 3 знаков после        *");
            Console.WriteLine("* запятой.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координаты углов (числа разделяйте пробелом):");

            string line = Console.ReadLine() ?? "";

            string[] parts = line.Split(' ');

            double x1 = Convert.ToDouble(parts[0]);
            double y1 = Convert.ToDouble(parts[1]);
            double x2 = Convert.ToDouble(parts[2]);
            double y2 = Convert.ToDouble(parts[3]);
            double x3 = Convert.ToDouble(parts[4]);
            double y3 = Convert.ToDouble(parts[5]);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь треугольника: " + ds.TriangleArea(x1, y1, x2, y2, x3, y3).ToString("F3") + " кв.см");

            Console.ReadLine();
        }
    }
}