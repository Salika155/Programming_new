﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class ShapeWithoutArea : Shape
    {
       
        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
