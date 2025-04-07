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
    public static void Main(String[] args)
    {
        Bird parrot = new Bird();
        parrot.fly();
        parrot.buildNest();
        System.Console.WriteLine("------------");
        Bird piegon = new Bird();
        piegon.fly();
        piegon.buildNest();
    }
}