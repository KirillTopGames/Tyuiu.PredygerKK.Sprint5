using System.Runtime.Intrinsics.X86;
using Tyuiu.PredygerKK.Sprint5.Task1.V17.Lib;

namespace Tyuiu.PredygerKK.Sprint5.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue, stopValue;
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Предыгер К.К. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Предыгер Кирилл Константинович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция.                                                           *");
            Console.WriteLine("* Произвести табулирование. f(x) на заданном диапазоне [-5; 5] с шагом 1. *");
            Console.WriteLine("* Произвести проверку деления нa ноль.                                    *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести      *");
            Console.WriteLine("* на консоль в таблицу.                                                   *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            startValue = -5;
            stopValue = 5;

            Console.WriteLine("Начало шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = stopValue - startValue + 1;

            double[] TempArray = new double[len];
            //
            int cnt = 0;
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) == -1)
                {
                    TempArray[cnt] = 0;
                    continue;
                }
                else
                {
                    y = 2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1));
                    TempArray[cnt] = y;
                }
                cnt++;
            }
            //
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Успешно создан!");

            Console.WriteLine("+-----------+----------+");
            Console.WriteLine("|     X     |   f(x)   |");
            Console.WriteLine("+-----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}      |{1, 6:f2}    |", startValue, TempArray[i]);
                startValue++;
            }
            Console.WriteLine("+-----------+----------+");
        }
    }
}
