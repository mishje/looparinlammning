using System;
class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Ange ett heltal:");
            int high = 0;
            int tal = int.Parse(Console.ReadLine());
            if (tal > high)
            {
                high = tal;
            }
            Console.WriteLine("Ett till? (j/n)");
            string svar = Console.ReadLine();
            switch (svar)
            {
                case "j":
                    break;
                default:
                    Console.WriteLine($"Högsta talet du angav var {high}");
                    return;
            }
        }while (true);
    }
}