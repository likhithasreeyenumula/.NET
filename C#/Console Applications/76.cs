using System;
class myCalci
{
    int a;
    int b;
    public int mysum()
    {
        return a+b;
    }
    public static void main()
    {
        myCalci mc=new myCalci();
        mc.a = 11;
        mc.b = 22;
        System.Console.WriteLine("Sum" +mc.mysum());
    }
}