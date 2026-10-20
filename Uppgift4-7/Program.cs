using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ange en sträng: ");
        string m = Console.ReadLine();
        Console.Write("Ange två nycklar (tecken): ");
        string c = Console.ReadLine();
        char c1 = c[0];
        bool c1true = false;
        char c2 = c[1];
        bool c2true = false;
        for (int i = 0; i < m.Length; i++)
        {
            if (c1 == m[i]) c1true = true;
            if (c2 == m[i]) c2true = true;
        }
        if( c1true && c2true) Console.WriteLine("Båda nycklarna finns i strängen.");
        else if (!c1true) Console.WriteLine($"{c1} fanns inte med");
        else if (!c2true) Console.WriteLine($"{c2} fanns inte med");
        else Console.WriteLine("Ingen nyckel fanns med.");
    }
}