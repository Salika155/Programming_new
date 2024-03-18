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

        //para acceder al constructor privado
        public static Race CreateRace()
        {
            return new Race();
        }

        public void AddObject(RaceObject? obj, double position)
        {
            if (position > 0 && position < _distance)
            {
                obj.Position = position;
                _RaceObjects.Add(obj);
            }
        }

        public void AddObject(Bomb bomb)
        {
            _RaceObjects.Add(bomb);
        }

        //public void AddObjectBomb(RaceObject obj, int turns, double position)
        //{
        //    obj.Position = position;
        //    _RaceObjects.Add(obj, turns);
        //}

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

        public bool IsWinner()
        {
            return GetRacers().Count == 1;
        }

        public RaceObject GetWinner()
        {
            List<RaceObject> racers = GetRacers();

            if (racers != null && racers.Count > 0 && IsWinner())
            {
                return racers[0]; 
            }
            return null;
        }

        public void Init(double distance)
        {
            if (distance > 0)
                _distance = 0;
            _distance = distance;
        }

        //cada turno llama al simulate de todos y comprueba de que esten vivos
        //funciones agregadas para visitar los objetos
        public void SimulateStep()
        {
            foreach (RaceObject obj in _RaceObjects)
            {
                obj.Simulate(this);
            }
            _RaceObjects.RemoveAll(obj => !obj.IsAlive);
        }

        public void VisitCars(List<RaceObject> visitor)
        {
            if (visitor == null)
                return;
            foreach (RaceObject obj in _RaceObjects)
            {
                if (obj.GetObjectType() == ObjectType.Car)
                    visitor.Add(obj);
            }
        }

        public void VisitDrivers(List<RaceObject> visitor)
        {
            foreach (RaceObject obj in _RaceObjects)
            {
                if (obj.GetObjectType() == ObjectType.Driver)
                    visitor.Add(obj);
            }
        }

        public void VisitObjects(List<RaceObject> visitor)
        {
            foreach (RaceObject obj in _RaceObjects)
            {
                visitor.Add(obj);
            }
        }

        public void VisitObstacles(List<RaceObject> visitor)
        {
            foreach (RaceObject raceObject in _RaceObjects)
            {
                if (raceObject.GetObjectType() == ObjectType.Obstacle)
                {
                    visitor.Add(raceObject);
                }
            }
        }

        void IRace.IsWinner()
        {
            GetWinner();
        }

        //public override RaceObject IsWinner()
        //{
        //    return GetWinner();
        //}
    }
}
