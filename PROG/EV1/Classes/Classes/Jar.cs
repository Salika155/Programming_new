using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Jar
    {
        private double capacity;
        private double quantity;

        /// <summary>
        /// This class function set the quantity of the Jar. NOT ACCETP NEGATIVE NUMBERS
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Return the restant quantity over the capacity number</returns>
        public double SetQuantity(double value)
        {
            if (value < 0)
            {
                return 0;
            }
            if (value > capacity)
            {
                quantity = capacity;
                return value - capacity;
            }
            else
            {
                quantity = value;
                return 0;
            }
        }
        public double GetQuantity()
        {
            return quantity;
        }
        /// <summary>
        /// This class function set max capacity of the Jar. NOT ACCEPT NEGATIVE NUMBERS. In case the quanitity over the capacity set with this function is exced, the quantity pass to be the max capacity.
        /// </summary>
        /// <param name="value"></param>
        public void SetCapacity(double value)
        {
            if ( value < 0) 
            {
                return;
            }
            if (value > quantity)
            {
                quantity = value;
                capacity = value;
            } else
            {
                capacity = value;
            }
        }
        public double GetCapacity()
        {
            return capacity;
        }
        /// <summary>
        /// This function return the Percentage of capacity in the Jar. If any value is in cero return 0.
        /// </summary>
        /// <returns></returns>
        public double GetPercent()
        {
            if (capacity == 0 || quantity == 0)
                return 0;
            return quantity / capacity;
        }
        public double GetRemain()
        {
            return capacity - quantity;
        }
        /// <summary>
        /// This function add quantity maintaning the quanitity of before. NOT ACCEPT NEGATIVE NUMBER. In case this Quantity the is over the capacity, the quantity pass to be the max capacity.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double AddQuantity(double value)
        {
            if (value < 0)
                return 0;
            if ( ( value + quantity ) > capacity)
            {
                quantity = capacity;
                return value - capacity;
            } else
            {
                quantity += value;
                return 0;
            }
        }
    }
}
