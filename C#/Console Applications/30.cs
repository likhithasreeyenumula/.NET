using System;
using System.Xml.Linq;
int a, b, c, d, e;
System.Console.WriteLine("Enter a:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter b:");
b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter c:");
c = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter d:");
d = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter e:");
e = Convert.ToInt32(Console.ReadLine());
int x = a;
if (b > x)
{
    x= b; 
}
else if (c > x)
{
    x= c;
}
else if (d > x)
{
    x= d;
}
else if (e > x)
{
    x= e;
}
System.Console.WriteLine(x + "is big");