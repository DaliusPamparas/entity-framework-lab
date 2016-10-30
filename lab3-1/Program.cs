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
            Console.WriteLine("Skriv en tal(helper class): ");
            float f = Hjalp.StringToFloat(Console.ReadLine());
            Console.WriteLine(f * 12);

            //extension class with this
            Console.WriteLine("Skriv en tal(extention method): ");
            float f1 = Console.ReadLine().ToFloat();
            Console.WriteLine(f1 * 12);
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

    public static class ExtentionMethodClass
    {
        public static float ToFloat(this string valueString)
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
