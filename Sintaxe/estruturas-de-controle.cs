using System;
namespace Programming
{
    class Program6
    {
        public static void Main(string[] args)
        {
            // If e else

            bool condition = true;

            if (condition)
            {
                Console.WriteLine("The variable is set to true.");
            }
            else
            {
                Console.WriteLine("The variable is set to false.");
            }
            

            // Exemplos:

            // Ex 1.:

            int m = 12;
            int n = 18;

            if (m > 10)
                if (n > 20)
                {
                    Console.WriteLine("Result1");
                }
                else
                {
                    Console.WriteLine("Result2");
                }

            // Ex 2.:

            int m1 = 12;
            int n1 = 8;

            if (m1 > 10)
            {
                if (n1 > 20)
                    Console.WriteLine("Result1");
            }
            else
            {
                Console.WriteLine("Result2");
            }

            // Switch/Case

            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}