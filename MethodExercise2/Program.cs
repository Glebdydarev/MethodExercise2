using System;

namespace MethodExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var name = Console.ReadLine();

            var result = Add(10, 20);

            Console.WriteLine(result);

            var result2 = Multiply(30, 50);

            Console.WriteLine(result2);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Substract(int num1, int num2)
        {
            return num1 - num2;

        }
        public static int Divide (int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Modulus (int num1, int num2)
        {
            return num1 % num2;  
        }
        
    }
}
