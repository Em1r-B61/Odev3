using System;
class Dortgen
{
    public int En;
    public int Boy;
    public int Alan()
    {
        int Alan = En * Boy;
        return Alan;
    }
    public void EnBoyBelirle(int en, int boy)
    {
        En = en;
        Boy = boy;
    }
    public void Yaz()
    {
        Console.WriteLine("***************");
        Console.WriteLine("En:{0}", En);
        Console.WriteLine("Boy:{0}", Boy);
        Console.WriteLine("Alan:{0}", Alan());
    }
}