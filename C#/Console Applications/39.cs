using System;
int i = 1;
while (i <= 20)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        System.Console.WriteLine("FuzzBuzz");
    }
    else if (i % 3 == 0)
    {
        System.Console.WriteLine("Fuzz");
    }
    else if (i % 5 == 0)
    {
        System.Console.WriteLine("Buzz");
    }
    else
    {
        System.Console.WriteLine(i);
    }
    i = i + 1;
}