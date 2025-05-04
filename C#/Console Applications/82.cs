using System;
class MyCalci
{
    public int a;
    public int b;
    public MyCalci()
    {
        a = x;
        b = y;
    }
    public void dispvals()
    {
        Console.WriteLine("a:" + a + "b:" + b);
    }
    public int add()
    {
        return a + b;
    }
    public static void main()
    {
        MyCalci obj=new MyCalci(20,10);
        obj.dispvals();
        Console.WriteLine("Sum:"+obj.add());
    }
}