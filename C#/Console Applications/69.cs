using System;
class Bird
{
    public void fly()
    {
        System.Console.WriteLine("fly");
    }
    public static void main(String[] args)
    {
        Bird parrot = new Bird();
        parrot.fly();
    }
}