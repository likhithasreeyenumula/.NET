using System;
int a, b, c;
System.Console.WriteLine("Enter A:");
a =Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter B:");
b =Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter C:");
c =Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    System.Console.WriteLine("A is Big");
}
else if (b > c)
{
    System.Console.WriteLine("B is Big");
}
else
{
    System.Console.WriteLine("c is Big");
}