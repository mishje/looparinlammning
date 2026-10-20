using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hur bred ska din stjärna vara?: ");
        int längd = int.Parse(Console.ReadLine());

        for (int i = 0; i < längd; i++)
        {
            int antal = (längd - ((längd - 1) - i));
            for (int j = 0; j < antal ; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}