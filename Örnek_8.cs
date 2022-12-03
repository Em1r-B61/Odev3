using System;
class Program
{
    static void Main()
    {
        int i = 0, a, n;

        Console.WriteLine("Bir Sayı Girin: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Artım Miktarı: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        for (; i < n;)
        {
            Console.WriteLine("{0}", i);
            i += a;
        }
    }
}