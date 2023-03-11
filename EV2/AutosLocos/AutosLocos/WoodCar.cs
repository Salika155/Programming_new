using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public class WoodCar : Car
    {
        
        private double _velocity;
        private CarType _type;

        public WoodCar(string name, double velocity)
        {
            
            _velocity = 10;
            _type = CarType.WoodCar;
        }

        public override ObjectType GetObjectType()
        {
            throw new NotImplementedException();
        }

        public override bool IsEnable()
        {
            throw new NotImplementedException();
        }

        public override void Simulate(IRace )
        {
            throw new NotImplementedException();
        }

        /*public override void Simulate(IRace)
        {
           
        }*/
    }
}
