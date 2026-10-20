using System;
class Program
{
    static void Main(string[] args)
    {
        string heltal = Console.ReadLine();
        int nytal = 0;
        for (int i = 0; i < heltal.Length; i++)
        {
            string tecken = heltal[i].ToString();
            int siffra = int.Parse(tecken);
            if (siffra == 9) siffra = 0;
            else siffra = siffra + 1;
            nytal = nytal * 10 + siffra;
        } 
        Console.WriteLine(nytal);
    }
}