using System;
interface A
{
    void gretone();
}
interface B
{
    void grettwo();
}
class C : A, B
{
    public void greetone()
    {
        Console.WriteLine("Hello form greet one");
    }
    public void greettwo()
    {
        Console.WriteLine("hello from greet two");
    }
    public static void main()
    {
        C objc=new C();
        objc.greetone();
        objc.greettwo();
    }
}