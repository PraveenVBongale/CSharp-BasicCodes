using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechACCELERATION
{
    internal class Acc
    {
        static void Main(string[] args)
        {
            int v, t, acc;
            Console.WriteLine("---WELCOME TO CALCULATE Acc in (m/s^2) ---");
            Console.WriteLine("Enter the Velocity 'v' in m/s = ");
            v = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Time 't' in sec = ");
            t = int.Parse(Console.ReadLine());
            acc = v / t;
            Console.WriteLine("Acceleration 'A'= {0} m/s^2", acc);
        }
    }
}
