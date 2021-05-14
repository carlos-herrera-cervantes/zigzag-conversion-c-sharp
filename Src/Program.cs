using System;
using Src.Models;

namespace Src
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "PAYPALISHIRING";
            var rows = 3;
            string result = SuperString.ConvertToZigZag(str, rows);

            Console.WriteLine($"RESULT: {result}");
        }
    }
}
