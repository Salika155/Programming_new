using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public delegate void RaceObjectVisitor(RaceObject obj);
    public class Race : IRace
    {
        private double _distance;
        private List<RaceObject> _RaceObjects = new List<RaceObject>();

        private Race()
        {
            _RaceObjects = new List<RaceObject>();
        }

        public void AddObject(RaceObject obj, double position)
        {
            if (position > 0 && position < _distance)
            {
                obj.Position = position;
                _RaceObjects.Add(obj);
            }
        }

        public RaceObject GetObjectAt(int index)
        {
            if (index >= 0 && index < _RaceObjects.Count)
                return _RaceObjects[index];
            return null;
        }

        public int GetObjectsCount()
        {
            return _RaceObjects.Count;
        }

        public List<RaceObject> GetRacers()
        {
            return _RaceObjects;
        }

        public void Init(double distance)
        {
            throw new NotImplementedException();
        }

        public void SimulateStep()
        {
            throw new NotImplementedException();
        }

        public void VisitCars(List<RaceObject> visitor)
        {
            throw new NotImplementedException();
        }

        public void VisitDrivers(List<RaceObject> visitor)
        {
            throw new NotImplementedException();
        }

        public void VisitObjects(List<RaceObject> visitor)
        {
            throw new NotImplementedException();
        }

        public void VisitObstacles(List<RaceObject> visitor)
        {
            throw new NotImplementedException();
        }
    }
}
