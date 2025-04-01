using System;
public void putempdet()
{
    System.Console.WriteLine("Eno:" + e.eno);
    System.Console.WriteLine("Ename:" + e.ename);
    System.Console.WriteLine("Esal:" + e.esal);
    System.Console.WriteLine("Egrade:" + e.egrade);   
}
class Test
{
    public static void Main()
    {
        Emp e = new Emp();
        e.eno = 101;
        e.ename = "Anil";
        e.esal = 4321.75;
        e.egrade = 'A';
        e.putempdet();
    }
}