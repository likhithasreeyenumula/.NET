using System;
class MyCalci
{
    public int a;
    public int b;
    public void getvals()
    {
        System.Console.WriteLine("Enter A:");
        a=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter B");
        b=Convert.ToInt32(Console.ReadLine());
    }
    public void putvals()
    {
        System.Console.WriteLine("A:"+a);
        System.Console.WriteLine("B:"+b);
    }
    public int mysum()
    {
        return a+b;
    }
    public int mysub()
    {
        return a-b;
    }
    public int mymul()
    { 
        return a*b;
    }
    public int mydiv()
    {
        return a/b;
    }
    public int mymod()
    {
        return a%b;
    }
    public static void main()
    {
        MyCalci mc = new MyCalci();
        int x;
        mc.getvals();
        mc.putvals();
        System.Console.WriteLine("-----------------------------");
        System.Console.WriteLine("Simple calculator");
        System.Console.WriteLine("------------------------------");
        System.Console.WriteLine("1.Add");
        System.Console.WriteLine("2.Sub");
        System.Console.WriteLine("3.Mul");
        System.Console.WriteLine("4.Div");
        System.Console.WriteLine("5.Mod");
        System.Console.WriteLine("------------------------------");
        System.Console.WriteLine("enter any one option (1-5):");
        x=Convert.ToInt32(Console.ReadLine());
        switch(x)
        {
            case 1:
                System.Console.WriteLine("Sum:" + mc.mysum());
                break;
            case 2:
                System.Console.WriteLine("Sub:" + mc.mysub());
                break;
            case 3:
                System.Console.WriteLine("Mul:" + mc.mymul());
                break;
            case 4:
                System.Console.WriteLine("Div:"+mc.mydiv());
                break;
            case 5:
                System.Console.WriteLine("mod:" + mc.mydiv());
                break;
            default:
                System.Console.WriteLine("invalid option");
                break;
        }
    }
}