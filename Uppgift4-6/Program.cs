using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Vad vill du skriva ut?: ");
        string w = Console.ReadLine();
        Console.Write("Hur mycket ska det vara förskjutet?: ");
        int f = int.Parse(Console.ReadLine());
        for(int i = 0; i < w.Length; i++)
        {
            for(int j = 0; j < f; j++) Console.Write(" ");
            Console.WriteLine(w[i]);
        }
    }
}