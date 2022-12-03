using System;

class dizi_6
{
    static void Main()
    {
        int[][] dizi = new int[3][];

        dizi[0] = new int[] { 1, 2 };
        dizi[1] = new int[] { 3, 4, 5, 6, 7 };
        dizi[2] = new int[] { 8, 9, 0 };

        foreach (int[] boyut in dizi)
        {
            foreach (int eleman in boyut)
            {
                Console.WriteLine("{0,3}", eleman);
            }
            Console.WriteLine();
        }
    }
}