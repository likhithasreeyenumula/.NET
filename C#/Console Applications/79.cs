using System;

class IceCream
{
    public int price;
    public int quantity;
    public double weight;
    public string color;

    public void Melt()
    {
        Console.WriteLine("It melts");
    }

    public int BillAmount()
    {
        return price * quantity;
    }

    public static void Main()
    {
        IceCream vanilla = new IceCream();
        vanilla.price = 20;
        vanilla.quantity = 5;
        vanilla.weight = 45.5;
        vanilla.color = "White";

        Console.WriteLine("Price: " + vanilla.price);
        Console.WriteLine("Quantity: " + vanilla.quantity);
        Console.WriteLine("Weight: " + vanilla.weight);
        Console.WriteLine("Color: " + vanilla.color);

        vanilla.Melt();
        Console.WriteLine("Bill Amount: " + vanilla.BillAmount());

        IceCream buttershotc = new IceCream();
        buttershotc.price = 20;
        buttershotc.quantity = 5;
        buttershotc.weight = 45.5;
        buttershotc.color = "yellow";

        Console.WriteLine("Price: " + buttershotc.price);
        Console.WriteLine("Quantity: " + buttershotc.quantity);
        Console.WriteLine("Weight: " + buttershotc.weight);
        Console.WriteLine("Color: " + buttershotc.color);

        buttershotc.Melt();
        Console.WriteLine("Bill Amount: " + buttershotc.BillAmount());
    }
}
