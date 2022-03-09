using System;
namespace Programming
{
    class Program3
    {
        public static async void Main(string[] args)
        {
            // Operadores Aritiméticos

            int i = 3;
            Console.WriteLine(i); // saida: 3
            Console.WriteLine(i++); // saida: 3
            Console.WriteLine(i); // saida: 4

            double a = 1.5d;
            Console.WriteLine(a); // saida: 1.5
            Console.WriteLine(++a); // saida: 2.5
            Console.WriteLine(a); // saida: 2.5

            int i1 = 3;
            Console.WriteLine(i); // saida: 3
            Console.WriteLine(i--); // saida: 3
            Console.WriteLine(i); // saida: 2

            double a3 = 1.5d;
            Console.WriteLine(a); // saida: 1.5
            Console.WriteLine(--a); // saida: 0.5
            Console.WriteLine(a); // saida: 0.5

            Console.WriteLine(+4); // saida: 4
            Console.WriteLine(-4); // saida: -4
            Console.WriteLine(-(-4)); // saida: 4

            Console.WriteLine(13 / 5);    // saída: 2
            Console.WriteLine(-13 / 5);   // saída: -2
            Console.WriteLine(13 / -5);   // saída: -2
            Console.WriteLine(-13 / -5);  // saída: 2

            Console.WriteLine(13 / 5.0);       // saída: 2.6
            int a4 = 13;
            int b = 5;
            Console.WriteLine((double)a / b);  // saída: 2.6

            Console.WriteLine(5 % 4);   // saída: 1
            Console.WriteLine(5 % -4);  // saída: 1
            Console.WriteLine(-5 % 4);  // saída: -1
            Console.WriteLine(-5 % -4); // saída: -1

            Console.WriteLine(5 + 4);       // saída: 9
            Console.WriteLine(5 + 4.3);     // saída: 9.3

            Console.WriteLine(47 - 3);      // saída: 44
            Console.WriteLine(5 - 4.3);     // saída: 0.7


            // Operadores de comparação

            Console.WriteLine(7.0 < 5.1);   // saída: False
            Console.WriteLine(5.1 < 5.1);   // saída: False
            Console.WriteLine(0.0 < 5.1);   // saída: True

            Console.WriteLine(double.NaN < 5.1);   // saída: False
            Console.WriteLine(double.NaN >= 5.1);  // saída: False

            Console.WriteLine(7.0 > 5.1);   // saída: True
            Console.WriteLine(5.1 > 5.1);   // saída: False
            Console.WriteLine(0.0 > 5.1);   // saída: False

            Console.WriteLine(double.NaN > 5.1);   // saída: False
            Console.WriteLine(double.NaN <= 5.1);  // saída: False

            Console.WriteLine(7.0 <= 5.1);   // saída: False
            Console.WriteLine(5.1 <= 5.1);   // saída: True
            Console.WriteLine(0.0 <= 5.1);   // saída: True

            Console.WriteLine(double.NaN > 5.1);   // saída: False
            Console.WriteLine(double.NaN <= 5.1);  // saída: False

            Console.WriteLine(7.0 >= 5.1);   // saída: True
            Console.WriteLine(5.1 >= 5.1);   // saída: True
            Console.WriteLine(0.0 >= 5.1);   // saída: False

            Console.WriteLine(double.NaN < 5.1);   // saída: False
            Console.WriteLine(double.NaN >= 5.1);  // saída: False

            // Operadores lógicos

            bool passed = false;
            Console.WriteLine(!passed);  // output: True
            Console.WriteLine(!true);    // output: False

            bool SecondOperand()
            {
                Console.WriteLine("Second operand is evaluated.");
                return true;
            }

            bool a1 = false & SecondOperand();
            Console.WriteLine(a);
            // Output:
            // Second operand is evaluated.
            // False

            bool b1 = true & SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluated.
            // True

            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False

            // Operadores de igualdade

            int a2 = 1 + 2 + 3;
            int b2 = 6;
            Console.WriteLine(a == b);  // output: True

            char c1 = 'a';
            char c2 = 'A';
            Console.WriteLine(c1 == c2);  // output: False
            Console.WriteLine(c1 == char.ToLower(c2));  // output: True

            string s1 = "hello!";
            string s2 = "HeLLo!";
            Console.WriteLine(s1 == s2.ToLower());  // output: True

            string s3 = "Hello!";
            Console.WriteLine(s1 == s3);  // output: False
        }
    }
}