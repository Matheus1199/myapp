using System;
namespace Programming
{
    class Program4
    {
        public static void Main(string[] args)
        {
            int var1 = 10;
            int var2 = 20;
            int var3 = 30;

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);

            Console.WriteLine(var1 > var2);
            Console.WriteLine(var2 != var3);

            var1++;
            var3--;

            Console.WriteLine(var1);
            Console.WriteLine(var3);
        }
    }
}