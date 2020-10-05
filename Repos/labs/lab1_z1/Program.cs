using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace lab1_z1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            int d = (int)(10 * x) % 10;
            Console.WriteLine($"d={d}");
        }
    }
}
