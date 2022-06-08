using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_8_CarPrototype
{
    class Kolesa: IClone
    {
        string name;
        double price;
        public Kolesa(string n, double pr)
        {
            name = n;
            price = pr;
        }
        public Kolesa(IClone a)
        {
            Kolesa temp = (Kolesa)a;
            name = temp.name;
            price = temp.price;
        }
        public IClone Clone()
        {
            return new Kolesa(this);
        }
        public override string ToString()
        {
            return $"Name: {name}\t Price: {price}";
        }
    }
}
