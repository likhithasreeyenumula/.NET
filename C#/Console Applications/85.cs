using System;
class A
{
    public void fofca()
    {
        System.Console.WriteLine("function of class A");
    }
}
class B : A
{
    public void fofcc()
    {
        System.Console.WriteLine("function of class c");
    }
    public static void main()
    {
        B objB=new B();
        objB.fofca();
        objB.fofcc();
        System.Console.WriteLine("---------------------");
        c objc = new c();
        objc.fofca();
        objc.fofcb();
        objc.fofcc();
    }
}