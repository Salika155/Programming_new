using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public void Move(int newx, int newy)
        {
            x = newx;
            y = newy;
        }

        public static bool operator == (Position p1, Position p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }

        public static bool operator != (Position p1, Position p2)
        {
            return p1.x != p2.x || p1.y != p2.y;
        }

        public override bool Equals(object obj)
        {
            //if (obj == null || GetType() != obj.GetType())
            //{
            //    return false;
            //}
            //Position p = (Position)obj;
            //return x == p.x && y == p.y;
            return base.Equals(obj);
        }

        public static Position operator + (Position p1, Position p2)
        {
            return new Position(p1.x + p2.x, p1.y + p2.y);
        }

        public static Position operator - (Position p1, Position p2)
        {
            return new Position(p1.x - p2.x, p1.y - p2.y);
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}
