using System;
class Toplama
{
    public int X;
    public int Y;

    public Toplama(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Toplama() : this(-1, -1) 
    { 
    }
    
    public Toplama(int x) : this(x, 1)
    {
    }

    public int Islem()
    {
        return X + Y;
    }

    public void Yaz()
    {
        Console.WriteLine("X = {0}", X);
        Console.WriteLine("Y = {0}", Y);
    }

    class Program
    {
        static void Main()
        {
            Toplama t = new Toplama(5, 6);
            t.Yaz();
            Toplama y = new Toplama();
            y.Yaz();
            Toplama u = new Toplama();
            u.Yaz();
        }
    }
}