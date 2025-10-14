using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KuchukIA.Sprint3.Task7.V24.Lib
{
    public class DataService : ISprint3Task7V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];

            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = (Math.Sin(x) / (x + 1.2)) - (Math.Sin(x) * 2) - (2 * x);
                res[count] = y;
                count++;
            }

            return res;
        }
      
    }
}
