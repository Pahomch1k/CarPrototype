using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_8_CarPrototype
{
    class Car: IClone
    {
        string name; 
        public Kolesa kolesa { get; set; }
        Dvigatel dvig;

        public Car(string n, Kolesa h, Dvigatel c)
        {
            name = n;
            kolesa = h;
            dvig = c;
        }
        Car() { }

        public IClone Clone()
        {
            Car car = new Car();
            car.name = this.name;
            car.kolesa = (Kolesa)this.kolesa.Clone();
            car.dvig = (Dvigatel)this.dvig.Clone();

            return car;
        }

        public void Print()
        {
            Console.WriteLine($"{kolesa}\n{dvig}");
        } 
    }
}
