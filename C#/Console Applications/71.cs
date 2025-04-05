using System;
class Bird
{
    public void fly()
    {
        System.Console.WriteLine("Fly");
    }
    public void buildNest()
    {
        System.Console.WriteLine("Nest");
    }
    public static void main(String[] args)
    {
        Bird parrot= new Bird();
        parrot.fly();
        parrot.buildNest();
    }
}