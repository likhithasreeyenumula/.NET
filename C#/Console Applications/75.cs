using System;
class mycalci
{
    int a, b;
    public void mysum(int x, int y)
    { 
        a = x; 
        b = y; 
        System.Console.WriteLine("sum:"+(a+b));
    }
    public static void main()
    {
        mycalci mc = new mycalci();
        mc.mysum(20, 10);
    }
}