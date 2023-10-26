using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Jar
    {
        private double _capacity;
        private double _quantity;

        public Jar() 
        {
            _capacity = 1000;
            _quantity = 0;

        }
        public double SetQuantity(double value)
        {
            if (value < 0)
            {
                return 0;
            }
            if (value > _capacity)
            {
                _quantity = _capacity;
                return value - _capacity;
            }
            else
            {
                _quantity = value;
                return 0;
            }
        }
        public double GetQuantity()
        {
            return _quantity;
        }
        
        public void SetCapacity(double value)
        {
            if ( value < 0) 
            {
                return;
            }
            if (value > _quantity)
            {
                _quantity = value;
                _capacity = value;
            } 
            else
            {
                _capacity = value;
            }
        }

        public double GetCapacity()
        {
            return _capacity;
        }
        
        public double GetPercent()
        {
            if (_capacity == 0 || _quantity == 0)
                return 0;
            return _quantity / _capacity;
        }

        public double GetRemain()
        {
            return _capacity - _quantity;
        }
        
        public double AddQuantity(double value)
        {
            if (value < 0)
                return 0;
            if ( ( value + _quantity ) > _capacity)
            {
                _quantity = _capacity;
                return value - _capacity;
            } 
            else
            {
                _quantity += value;
                return 0;
            }
        }
    }
}
