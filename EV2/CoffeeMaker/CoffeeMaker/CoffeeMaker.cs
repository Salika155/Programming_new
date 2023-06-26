using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public enum CoffeeMakerState
    {
        Filled,
        Empty,
        InProgress
    }


    public class CoffeeMaker
    {
        private double _maxCapacity;
        private double _actualCapacity;
        public CoffeeMakerState _coffeeMakerState;

        public CoffeeMaker() 
        {
            _maxCapacity = 1000;
            _actualCapacity = 0;
        }

        public CoffeeMaker(double maxCapacity)
        {
            _maxCapacity = maxCapacity;
            _actualCapacity = maxCapacity;
            
        }

        public CoffeeMaker(double maxCapacity, double actualCapacity) 
        {
            _maxCapacity = maxCapacity;
            if (maxCapacity < actualCapacity) 
            {
               _actualCapacity = maxCapacity;
            }
            else
                _actualCapacity = actualCapacity;
                
        }

        public void FillCoffeeMaker()
        {
           if (_actualCapacity < _maxCapacity)
            {
                _actualCapacity = _maxCapacity;
            }
        }

        public void ServeCup(int coffeeCup)
        {
            if (_actualCapacity <= coffeeCup)
            {
                _actualCapacity = 0;
            }
            else 
                _actualCapacity -= coffeeCup;
        }

        public void EmptyCoffeeMaker()
        {
            _actualCapacity = 0;
        }

        public void FillCoffeeMaker(int coffeeQuantity)
        {
            _actualCapacity += coffeeQuantity;
            if (_actualCapacity > _maxCapacity)
            {
                _actualCapacity = _maxCapacity;
            }
        }

        public CoffeeMakerState GetState()
        {
            if (_actualCapacity == 0)
                return CoffeeMakerState.Empty;
            if (_actualCapacity == _maxCapacity)
                return CoffeeMakerState.Filled;
            else
                return CoffeeMakerState.InProgress;
        }

        public CoffeeMaker CloneCoffeeMaker()
        {
            CoffeeMaker c = new CoffeeMaker(_maxCapacity, _actualCapacity);
            return c;
        }

        public double MaxCapacity
        {
            get { return _maxCapacity; }
        }

        public double ActualCapacity
        {
            get { return _actualCapacity; }
        }

        public CoffeeMakerState CoffeeMakerState
        {
            get { return _coffeeMakerState; }
        }

    }
}
