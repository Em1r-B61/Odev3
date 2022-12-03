using System;
enum Gunler : byte
{
    PAZARTESI,
    SALI,
    CARSAMBA,
    PERSEMBE,
    CUMA,
    CUMARTESI,
    PAZAR
}
class Numaralandirma
{
    public static void Main()
    {
        Console.WriteLine((int)Gunler.PAZARTESI+1);
        Console.WriteLine((int)Gunler.PAZAR+1);
    }
}