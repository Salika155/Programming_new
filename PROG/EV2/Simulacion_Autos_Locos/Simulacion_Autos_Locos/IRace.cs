using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    //public delegate void ActionDrivers<T>(T obj);
    public interface IRace
    {
        List<RaceObject> GetRacers();
        //Agrega un objeto a la carrera en una posicion
        void AddObject(RaceObject obj, double position);
        //void AddObjectBomb(RaceObject obj, int turns, double position);
        //Inicia la carrera con una distancia
        void Init(double distance);
        //Simula el avance de la carrera
        void SimulateStep();

        //recibe una lambda que recibe un RaceObject y no devuelve nada
        void VisitDrivers(List<RaceObject> visitor);
        void VisitCars(List<RaceObject> visitor);
        void VisitObstacles(List<RaceObject> visitor);
        void VisitObjects(List<RaceObject> visitor);
        //devuelve la cantidad de objetos en la carrera
        int GetObjectsCount();
        //devuelve el objeto en la posicion index
        RaceObject GetObjectAt(int index);
        void AddObject(Bomb bomb);

        //la unica forma que encontre de que funcionase
        void IsWinner();
        RaceObject GetWinner();
        //RaceObject GetRacers();
    }
}
