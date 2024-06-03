using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ajedrez
{
    abstract class Figure : IFigure
    {
        private FigureColor Color { get; }
        private Position Position { get; set; }
        private bool HasMoved { get; set; }

        public Figure(FigureColor color, Position position)
        {
            Color = color;
            Position = position;
            HasMoved = false;
        }

        public Position GetPosition()
        {
            return Position;
        }

        public abstract List<Position> GetAvailablePosition();
        
        public FigureColor GetFigureColor()
        {
            return Color;
        }

        public abstract FigureType GetFigureType();
        //como estos seran caracteristicas que se definiran en clases hijas, estos se lo pasan 
        //a las hijas en modo de abstract para que las otras hagan override
        
        public bool HasBeenMoved()
        {
            return HasMoved;
        }

        public void MoveTo(Position position)
        {
            Position = position;
            HasMoved = true;
        }
    }
}
