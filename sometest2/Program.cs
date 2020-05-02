using System;

namespace sometest2
{
    static class MyConvert
    {
        public static int ToInt(this string a)
        {
            return Convert.ToInt32(a);
        }
    }

    static class MeRandomFromMinToMax
    {
        public static double NextDouble(this Random rnd, double min, double max)
        {
            return rnd.NextDouble() * (max-min) + min;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var arg1 = "100500";
            Console.Write(arg1.ToInt() + "42".ToInt()); // 100542
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Default random:");
            var rnd = new Random();
            Console.WriteLine(rnd.NextDouble());

            Console.WriteLine("My random form 3 to 9:");
            Console.WriteLine(rnd.NextDouble(3, 9));
        }
    }
}
