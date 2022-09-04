using System;

class Program
{
    static void Main(string[] args)
        {
            int power;

            int.TryParse(Console.ReadLine(), out power);

            Console.WriteLine(pow(power));

            Console.ReadLine();
        }

        public static int pow(int power)
        {
            if (power == 0)
                return 1;
            return 2*pow(--power);
        }
}