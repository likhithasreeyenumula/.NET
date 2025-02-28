using System;
using System.Security.Cryptography;
int i = 9;
while (i > 2)
{
    System.Console.WriteLine(i + "bottles of beer on the wall," + i + "bottles of beer");
    System.Console.WriteLine("Taken one down and pass it around," + (i + 1) + "bottles on the wall /n");
    i = i - i;
}
System.Console.WriteLine("1 bottles of beer on the wall,1 bottle of beer");
System.Console.WriteLine("Taken one down and pass it around,no more bottles of beer on the wall /n");

System.Console.WriteLine("no more bottles of beer on the wall,no more bottle of beer");
System.Console.WriteLine("go to the store and buy some more,9 bottles of beer the on the wall");