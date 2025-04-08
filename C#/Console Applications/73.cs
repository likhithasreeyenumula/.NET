using System;
class Bird
{
    public int age;
    public int wings;
    public double wt;
    public string color;
    public void fly()
    {
        System.Console.WriteLine("fly");
    }
    public void Nest()
    {
        System.Console.WriteLine("Nest");
    }
    public static void main (string[] args)
    {
        Bird parrot = new Bird();
        parrot.age = 5;
        parrot.wings = 2;
        parrot.wt = 5.2;
        parrot.color = "Green";
        System.Console.WriteLine("Age:"+parrot.age);
        System.Console.WriteLine("Wings:"+parrot.wings);
        System.Console.WriteLine("weight:" + parrot.wt);
        System.Console.WriteLine("Color:"+parrot.color);
        parrot.fly();
        parrot.Nest();
    }
}