using System;
class myCalci
{
    int a;
    int b;
    public int mysum(int x, int y)
    {
        a = x;
        b = y;
        return a+b;
    }
    public static void main()
    {
        myCalci mc = new myCalci();
        System.Console.WriteLine("sum:"+mc.mysum(10,50));
    }
}