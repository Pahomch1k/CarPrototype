using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_8_CarPrototype
{
    class Dvigatel: IClone
    {
        string name;
        double price;
        public Dvigatel(string n, double pr)
        {
            name = n;
            price = pr;
        }
        public Dvigatel(IClone a)
        {
            Dvigatel temp = (Dvigatel)a;
            name = temp.name;
            price = temp.price;
        }
        public IClone Clone()
        {
            return new Dvigatel(this);
        }
        public override string ToString()
        {
            return $"Name: {name}\t Price: {price}";
        }
    }
}
