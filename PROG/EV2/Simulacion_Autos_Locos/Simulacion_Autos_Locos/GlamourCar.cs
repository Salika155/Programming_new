﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public class GlamourCar : Car
    {
        public GlamourCar(string driverName) : base(Utils.GetRandomDouble(0.0, 3.0), 20, GenerateDrivers(driverName), "El Compact Pussycat")
        {
        }

        static List<Driver> GenerateDrivers(string driverName)
        {
            return new List<Driver> { new Human("Penelope") };
        }

        public override void Simulate(IRace race)
        {
            if (race == null) 
                return;
            if (_turnsDisabled > 0)
            {
                _turnsDisabled--;
                return;
            }
            Position += 20 + _finetunning;
        }

        //isdisabled
    }
}
