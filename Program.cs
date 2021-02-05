using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Double movements = 0;
            int Min_Range=0;
            int Max_Range;
            int counter_steps = 0;
            string sign = null;
            int mean = 0;

            Console.Write("Hello, set range numbers from 1 to 2 147 483 647: ");
            int Lenght_array = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            movements = Math.Round(Math.Log2(Lenght_array));

            Console.WriteLine($"Now, choose any one number from your range. I anserwer in max {movements} moves");
            Console.WriteLine("When your number is smaller than writed click '<' when bigger click '>' if equal '='");

            int[] array = new int[Lenght_array];

            for (int i = 0; i < Lenght_array; i++)
            {
                array[i] = i+1;
            }

            Min_Range = array[0];
            Max_Range = array[Lenght_array-1];

            do
            {
                counter_steps++;
                mean = (Min_Range + Max_Range) / 2;
                Console.Write($"{counter_steps}: Your number it is {mean} ?");
                Console.Write("Get me a sign: ");
                sign = Console.ReadLine();

                if (sign == "<")
                {
                    Max_Range = mean;
                }
                else if (sign == ">")
                {
                    Min_Range = mean;
                }
                else if (sign == "=")
                {
                    Console.WriteLine($"Hah, I geues i limit {movements}!");
                    break;
                }
            }
            while (counter_steps != movements);
        }
    }
}
