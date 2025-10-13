using System;
using Tyuiu.KuchukIA.Sprint3.Task4.V4.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                   *");
        Console.WriteLine("* Тема: Алгоритмы циклической структуры                                                       *");
        Console.WriteLine("* Задание #4                                                                                  *");
        Console.WriteLine("* Вариант #4                                                                                  *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции                 *");
        Console.WriteLine("y=x/(cos(x)+sin(x)) При х = 0 прервать цикл. Полученные значения суммировать.                 *");
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

        Console.WriteLine("Сумма ряда: " + ds.Calculate(startValue, stopValue));


        Console.ReadKey();

    }
}
