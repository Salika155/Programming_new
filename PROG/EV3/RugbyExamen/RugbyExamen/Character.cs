using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public abstract class Character
    {

        public int _x;
        public int _y;


        public Character() 
        {
            _x = 0;
            _y = 0;
        }

        public int X
        { get { return _x; } set { _x = value; } }
        public int Y
        { get { return _y; } set { _y = value; } }
        
        

        public virtual void ExecuteTurn()
        {
           
        }

        //public void Move(int x, int y)
        //{
        //    _x = x;
        //    _y = y;
        //}

    }
}
