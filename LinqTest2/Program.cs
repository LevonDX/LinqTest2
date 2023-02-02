using System.Linq;
namespace LinqTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> x = new List<int>() { 3, 4, 2, 4, 6, 9, 2, 1, 3, 5, 21 };

            IEnumerable<int> ts = x
                .SkipWhile(a => a < 9)
                .Where(a => a % 3 == 0);

            //var list = x.Where(a => a % 3 == 0).ToList(); // correct

            //var list2 = x.ToList().Where(a => a % 3 == 0); // Incorrect

            foreach (int item in ts)
            {
                Console.WriteLine(item);
            }
        }
    }
}