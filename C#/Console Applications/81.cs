class MyCalci
{
    public int a;
    public int b;
    public MyCalci()
    {
        a = 6;
        b = 7;
    }
    public void dispvals()
    {
        Console.WriteLine("A:" + a + "B:" + b);
    }
    public int add()
    {
        return a + b;
    }
    public static void main()
    {
        MyCalci obj = new MyCalci();
        obj.dispvals();
        Console.WriteLine("sum:" + obj.add());
    }
}