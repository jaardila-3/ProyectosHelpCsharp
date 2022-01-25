using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsParallel_PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var cronómetro = new Stopwatch();
            cronómetro.Start();

            var numbers = Enumerable.Range(0, 10000);
            var filterNumber = (from n in numbers.AsParallel()//.AsOrdered()//.WithDegreeOfParallelism(4)
                                where IsValid(n)
                                select n
                ).ToList();

            foreach (var item in filterNumber)
            {
                System.Console.WriteLine(item);
            }

            //Parallel.ForEach(filterNumber, (item) =>
            //{
            //    System.Console.WriteLine(item);
            //});

            System.Console.WriteLine($"tardo en ms: {cronómetro.ElapsedMilliseconds}");
            System.Console.ReadLine();
        }

        static bool IsValid(int num)
        {
            Thread.Sleep(10);
            if (num % 2 != 0) return false;
            if (num % 5 != 0) return false;

            return true;
        }
    }
}
