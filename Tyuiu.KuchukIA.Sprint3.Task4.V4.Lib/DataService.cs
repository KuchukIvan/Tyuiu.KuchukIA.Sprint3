using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KuchukIA.Sprint3.Task4.V4.Lib
{
    public class DataService : ISprint3Task4V4
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i != 0)
                {
                    res = res + (i / (Math.Cos(i) + Math.Sin(i)));
                }
                else
                {
                    break;
                }
            }
            return Math.Round(res, 3);
        }
    }
}
