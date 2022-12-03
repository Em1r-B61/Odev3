using System;
class dizi_4
{
    static void Main()
    {
        int[,] dizi = { { 1, 2}, { 3, 4 }, { 5, 6 } };

        for (int i=0; i<3; i++)
            for (int j=0; j<2; j++)
            {
                Console.WriteLine(dizi[i, j]);
            }
    }
}