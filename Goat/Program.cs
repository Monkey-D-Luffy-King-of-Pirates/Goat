using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Goat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var squareSide = 8;
            var ropeLength = 5;
            var a = Math.Sqrt(2);
            var squareDiagonal = squareSide * a;
            var pi = Math.PI;
            double result0;
            double result;
            double result1;
            if ((ropeLength <= squareSide / 2) || (ropeLength >= squareDiagonal / 2))
            {
                result = pi * (ropeLength * ropeLength);
                Console.WriteLine(result);
            }
            else 
            {
                //w ^ 2 - 2((w / 2 - sqrt(r ^ 2 - (w ^ 2) / 4) ^ 2)
                result0 = Math.Sqrt(ropeLength * ropeLength - (squareSide * squareSide) / 4);
                result = squareSide / 2 - result0;
                result1 = squareSide * squareSide - 2 * (result * result);
                Console.WriteLine(result1);
            }
            Console.ReadKey();
        }
    }
}
