using System;
int age;
System.Console.WriteLine("enter age:");
age =Convert.ToInt32(Console.ReadLine());
if (age >= 65)
{
    System.Console.WriteLine("senior citizen");
    System.Console.WriteLine("Eligible for vote");
}
else if (age >= 65 && age >= 18)
{
    System.Console.WriteLine("Major citizen");
    System.Console.WriteLine("Eligible for vote");
}
else
{
    System.Console.WriteLine("Minor citizen");
    System.Console.WriteLine("Not Eligible for vote");
}