using System;

namespace Dz_8_CarPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Kolesa kol = new Kolesa("Winter", 5000);
            Dvigatel dv = new Dvigatel("300LL", 30000);

            Car car = new Car("Audi", kol, dv); 
            car.Print();

            Car carcopy = (Car)car.Clone();
            Console.WriteLine("CarCopy");
            carcopy.Print(); 
        }
    }
}
