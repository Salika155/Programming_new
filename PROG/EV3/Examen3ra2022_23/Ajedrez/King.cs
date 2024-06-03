using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    internal class King : Figure
    {
        public King(FigureColor color, Position position) : base(color, position)
        {

        }

        public override List<Position> GetAvailablePosition()
        {
            List<Position> positions = new List<Position>();

            int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

            foreach (int x in dx)
            {
                foreach (int y in dy)
                {
                    if (x != 0 || y != 0)
                    {
                        int newX = Position.X + x;
                        int newY = Position.Y + y;
                        if (newX >= 0 && newX < 8 && newY >= 0 && newY < 8)
                        {
                            positions.Add(new Position(newX, newY));
                        }
                    }
                }
            }

            return positions;
        }

        
        public override FigureType GetFigureType()
        {
            return FigureType.King;
        }
    }
}
