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

    class Program
    {
        static void Main(string[] args)
        {
            var arg1 = "100500";
            Console.Write(arg1.ToInt() + "42".ToInt()); // 100542
        }
    }
}
