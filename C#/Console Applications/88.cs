using System;
abstract class Bank
{
    public abstract void itrate();
}
class SBI : Bank
{
    public override void itrate()
    {
        Console.WriteLine("SBI Bank Intrest rate is");
    }
}
class HDFC : Bank
{
    public override void itrate()
    {
        Console.WriteLine("HDFC Bank Insterest rate is 9%");
    }
    public static void main()
    {
        Bank b;
        b = new SBI();
        b.itrate();
        b=new HDFC();
        b.itrate();
    }
}