using System;
using Tyuiu.KuchukIA.Sprint3.Task7.V24.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                                       *");
        Console.WriteLine("* Задание #7                                                                                  *");
        Console.WriteLine("* Вариант #24                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции                                *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        


        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        double[] res = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("+---------+------------+");
        Console.WriteLine("|    x    |     f(x)   |");
        Console.WriteLine("+---------+------------+");

        for (int i = 0; i <= res.Length - 1; i++)
        {
            Console.WriteLine("|{0,5:d}    |    {1,5:f2}   |", startValue, res[i]);
            startValue++;
            
        }

        Console.WriteLine("+---------+------------+");

        Console.ReadKey();

    }
}
