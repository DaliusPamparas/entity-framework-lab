using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //helper static class
            Console.WriteLine("Skriv en tal: ");
            float f = Hjalp.StringToFloat(Console.ReadLine());
            Console.WriteLine(f * 12);
            Console.ReadKey();
        }

    }
    public static class Hjalp
    {
        public static float StringToFloat(string valueString)
        {
            float output;
            bool isString = float.TryParse(valueString, out output);
            if (isString)
                return output;
            else
                return 0;
        }
    }
}
