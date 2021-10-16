using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_1610
{
    enum Carrier
    {
        Paper,
        Electronic,
        Both
    }
    class EduMaterial : Good
    {        
        public Person Creator;
        public Carrier Carrier;        
        public EduMaterial() { }
        public EduMaterial(string Name, Person Creator, Carrier Carrier)
        {
            this.Name = Name;
            this.Creator = Creator;
            this.Carrier = Carrier;
        }
        public EduMaterial(string Name, Person Creator, Carrier Carrier, uint Price, uint Quantity)
        {
            this.Name = Name;
            this.Creator = Creator;
            this.Carrier = Carrier;
            SetPrice(Price, "123");
            this.Quantity = Quantity;
        }        
    }
}
