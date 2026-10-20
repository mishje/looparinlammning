using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hur många X per grupp?: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Hur många O per grupp?: ");
        int o = int.Parse(Console.ReadLine());
        Console.Write("Hur många O grupper per rad?: ");
        int opr = int.Parse(Console.ReadLine());
        Console.Write("Hur många rader?: ");
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int k = 0; k < r; k++)
        {
            for (int i = 0; i < x; i++) Console.Write("X");
            for (int i = 0; i < opr; i++)
            {
                Console.Write("-");
                for (int j = 0; j < o; j++) Console.Write("O");
                Console.Write("-");
                for (int j = 0; j < x; j++) Console.Write("X");
            }
            Console.WriteLine();
        }
    }
}