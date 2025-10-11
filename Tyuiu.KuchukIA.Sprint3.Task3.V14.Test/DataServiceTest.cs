using Tyuiu.KuchukIA.Sprint3.Task3.V14.Lib;
namespace Tyuiu.KuchukIA.Sprint3.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();
            string str = "da da da da";
            string res = ds.ReplaceCharInString(str, 'd', '’');
            string wait = "’a ’a ’a ’a";

            Assert.AreEqual(wait, res);

        }
    }
}
