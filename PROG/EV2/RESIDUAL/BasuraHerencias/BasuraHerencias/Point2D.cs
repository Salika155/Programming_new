﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class Point2D
    {
        public double _x;
        public double _y;

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Point2D()
        {

        }

        public double X
        { 
          get { return _x; } 
          set { _x = value; } 
        }

        public double Y
        {
            get { return _y; } 
            set { _y = value; }
        }

    }
}
