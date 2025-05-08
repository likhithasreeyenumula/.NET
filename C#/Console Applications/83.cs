using System;

class Car
{
    string brand;
    public Car(string theBrand)
    {
        brand = theBrand;
    }
    public Car(Car otherCar)
    {
        brand = otherCar.brand;
    }
    static void Main(string[] args)
    {
        Car car1 = new Car("Bugatti");
        Console.WriteLine("Brand of car: " + car1.brand);

        Car carz = new Car(car1);
        Console.WriteLine("Brand of car: " + carz.brand);
    }
}
