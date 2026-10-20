using System;
class Program
{
    static void Main(string[] args)
    {
        int tal1;
        int tal2;
        do
        {
            Console.WriteLine("Välj ett av följande alternativ:");
            Console.WriteLine("1. Differensen mellan två tal");
            Console.WriteLine("2. Summan mellan två tal");
            Console.WriteLine("3. Avsluta programmet");
            Console.Write("Ditt val: ");
            int val = int.Parse(Console.ReadLine());
            switch (val)
            {
                case 1:
                    Console.Write("Tal 1: ");
                    tal1 = int.Parse(Console.ReadLine());
                    Console.Write("Tal 2: ");
                    tal2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Differensen av de två talen är: " + (tal1 - tal2));
                    break;
                case 2:
                    Console.Write("Tal 1: ");
                    tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Tal 2: ");
                    tal2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Summan av de två talen är: " + (tal1 + tal2));
                    break;
                case 3:
                    Console.WriteLine("Programmet avslutas.");
                    return;
                default:
                    Console.WriteLine("Ej giltigt svar. (1/2/3)");
                    break;
            }

        } while (true);


    }
}