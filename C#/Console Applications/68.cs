using System;
struct emp
{
    public int eno;
    public string ename;
    public double esalary;
    public char egrade;
    public void getempdet()
    {
        System.Console.WriteLine("Enter Eno:");
        eno = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter Ename:");
        ename = Console.ReadLine();
        System.Console.WriteLine("Enter Esalary:");
        esalary = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Enter Egrade:");
        egrade = Convert.ToChar(Console.Read());
    }
    public void putempdet()
    {
        System.Console.WriteLine("Eno:" + eno);
        System.Console.WriteLine("Ename:" + ename);
        System.Console.WriteLine("Esalary:" + esalary);
        System.Console.WriteLine("Egrade:" + egrade);
    }
}
class Test
{
    public static void Main()
    {
        emp e=new emp();
        e.getempdet();
        e.putempdet();
    }
}