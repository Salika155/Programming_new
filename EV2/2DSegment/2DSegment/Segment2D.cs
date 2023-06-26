using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Linq;
using Segment2D;


namespace Segment2D
{
    public class Segment2D
    {
        private Point2D _APoint;
        private Point2D _BPoint;

        public Segment2D()
        {

        }
        public Segment2D(Point2D pointA, Point2D pointB)
        {
            _APoint = pointA;
            _BPoint = pointB;
        }

        public void MoveRightLine(double distance) 
        {
            _APoint.x += distance;
            _BPoint.x += distance;
        }

        public void MoveLeftLine(double distance)
        {
            _APoint.x -= distance;
            _BPoint.x -= distance;
        }

        public void MoveUpLine(double distance) 
        {
            _APoint.y += distance;
            _BPoint.y += distance;
        }

        public void MoveDownLine(double distance)
        {
            _APoint.y -= distance;
            _BPoint.y -= distance;
        }

        public override string ToString()
        {
            return "Segment A = (" + _APoint.x + ", " + _APoint.y + ")" + "\nSegment B = (" + _BPoint.x + ", " + _BPoint.y + ")";
        }

        public double GetDistance()
        {
            double average = Math.Sqrt((_BPoint.x - _APoint.x) * (_BPoint.x - _APoint.x) + (_BPoint.y - _APoint.y) * (_BPoint.y - _APoint.y));
            return average;
        }

        public Point2D GetAveragePoint()
        {
            Point2D AveragePoint = new Point2D();
            AveragePoint.x = (_APoint.x + _BPoint.x)/2;
            AveragePoint.y = (_APoint.y + _BPoint.y)/2;
            return AveragePoint;
        }

        public void SwapYValors(Segment2D s2)
        {
            double auxY;

            auxY = _APoint.y;
            _APoint.y = _BPoint.y;
            _BPoint.y = auxY;    
        }

        public void SwapXValors()
        {
            double auxX;

            auxX = _APoint.x;
            _APoint.x = _BPoint.x;
            _BPoint.x = auxX;
        }

        public bool IntersectWith(Segment2D segment)
        {
            if (IsOutOfRange(segment))
                return false;
            if (IsInsideOfRange(segment))
                return false;
            if (segment.IsOutOfRange(this))
                return false;
            return true;
        }

        public bool IsOutOfRange(Segment2D segment)
        {
            if (_APoint.x > segment._BPoint.x)
                return true;
            if (_BPoint.x < segment._APoint.x)
                return true;
            if (_APoint.y > segment._BPoint.y)
                return true;
            if (_BPoint.y < segment._APoint.y)
                return true;
            return false;
        }

        public bool IsInsideOfRange(Segment2D segment)
        {
            if (_APoint.x >= segment._APoint.x)
                return true;
            if (_APoint.x <= segment._BPoint.x)
                return true;
            if (_BPoint.x >= segment._APoint.x)
                return true;
            if (_BPoint.x <= segment._BPoint.x)
                return true;
            if (_APoint.y >= segment._APoint.y)
                return true;
            if (_APoint.y >= segment._BPoint.y)
                return true;
            if (_BPoint.y >= segment._APoint.y)
                return true;
            if (_BPoint.y <= segment._BPoint.y)
                return true;
            return false;
        }
    }
}
