using System.Security;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KuchukIA.Sprint3.Task2.V5.Lib
{
    public class DataService : ISprint3Task2V5
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            do
            {
                sum = sum + ((Math.Pow(value, startValue) + 1) * Math.Cos(startValue));
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(sum, 3);
        }
    }
}
