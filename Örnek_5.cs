using System;
class Program
{
    static void Main()
    {
        int secim;
        do
        {
            Console.WriteLine("İşlemler\n========");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.WriteLine("0 - Çıkış");
            Console.WriteLine("İşleminizi Seçin:");
            secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1: Console.WriteLine("Toplama İşlemi Seçildi.\n "); break;
                case 2: Console.WriteLine("Çıkarma İşlemi Seçildi.\n "); break;
                case 3: Console.WriteLine("Çarpma İşlemi Seçildi.\n "); break;
                case 4: Console.WriteLine("Bölme İşlemi Seçildi.\n "); break;
                case 0: Console.WriteLine("Çıkış Seçildi.\n "); break;
                default: Console.WriteLine("Yanlış Seçim.\n "); break;
            }
        }
        while (secim != 0);
    }
}