using System;
class program
{
    public static void Main()
    {
        int a = 2; int b = 3; int c = 6; int d = 1;

        Console.WriteLine("(a<b)&&(c<d) --> " + ((a < b) && (c < d)));
        Console.WriteLine("(a<b)||(c<d) --> " + ((a < b) || (c < d)));
        Console.WriteLine("! (a<b) --> " + (!(a < b)));
        Console.WriteLine("(a<b)&(c<d) --> " + ((a < b) & (c < d)));
        Console.WriteLine("(a<b)|(c<d) --> " + ((a < b) | (c < d)));
        Console.WriteLine("(a<b)^(c<d) --> " + ((a < b) ^ (c < d)));
    }
}