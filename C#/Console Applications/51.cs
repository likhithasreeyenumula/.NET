using System;
int a, b, c;
char ch;
do
{
    System.Console.WriteLine("Enter a:");
    a=Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Enter b:");
    b=Convert.ToInt32(Console.ReadLine());
    c = a + b;
    System.Console.WriteLine("Sum:" + c);
    System.Console.WriteLine("Do you want to do again");
    ch=Convert.ToChar(Console.ReadLine());
}
while (ch=='Y'||ch=='y');