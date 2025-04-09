using System;
class mycalci
{
    int a, b;
    public void mysum()
    {
        System.Console.WriteLine("Sum="+(a+b));
    }
    public static void main()
    {
        mycalci mc = new mycalci();
        mc.a = 5;
        mc.b = 5;
        mc.mysum();
    }
}