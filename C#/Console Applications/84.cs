using System;
class Rect
{
    public int l;
    public int b;
    public int area()
    {
        return l * b;
    }
    public static void main()
    {
        Rect R = new Rect();
        R.l = 20;
        R.b = 40;
        System.Console.WriteLine("Area:"+R.area());
    }
}