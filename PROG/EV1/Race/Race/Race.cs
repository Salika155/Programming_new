using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Race
{  
    public class Race
    {
        private List<Runner> runners;
        public double meta = 100.0;

       

        public Race(List<Runner> runners)
        {
            this.runners = runners;
            this.meta = 100;
        }

        public Race()
        {
            this.runners = new List<Runner>(); 
            this.meta = 100;
        }

        public int GetRunnersCount() 
        {
            return runners.Count;
        }

        public List<Runner> GetRunner()
        {
            return runners;
        }

        public Runner? GetRunnerAtIndex(int index) 
        {
            if (index >= 0 && index < runners.Count) 
            {
                return runners[index];
            }
            return null;
        }

        public void CreateRunners(int countRunner, teamType team)
        {
            for (int i = 0; i < countRunner; i++)
            {

                int age = Utils.GetRandom(16, 42);
                double velocity = Utils.GetRandomDouble(0, 1);
                int position = 0;
                team = (teamType)Utils.GetRandom(0, 3);
                Runner runner = new Runner(age, 0, 0, team);
                AddRunner(runner);
            }
        }

        public void CreateRunners(int A, int B, int C, int D)
        {
            CreateRunners(A, teamType.A);
            CreateRunners(B, teamType.B);
            CreateRunners(C, teamType.C);
            CreateRunners(D, teamType.D);
        }


        private void AddRunner(Runner? runner) 
        {
            if (runner == null)
                return;
            runners.Add(runner);
            
        }

        public double GetMeta()
        {
            return meta;
        }


        public void MoveRunner(int position)
        {
            if (position >= 0 && position <= meta)
            {
                for (int i = 0; i < runners.Count; i++)
                {
                    Runner runner = runners[i];
                    runner.GetPosition();
                }
            }
        }

        public Runner? GetRunnerWithName(string name)
        {
            for (int i = 0; i < runners.Count; i++)
            {
                if (runners[i].GetName() == name)
                    return runners[i];
            }
            return null;
        }

        public Runner? RemoveRunnerAt(int index)
        {
            if (index >= 0 && index < runners.Count)
            {
                Runner removedrunner = runners[index];
                runners.RemoveAt(index);
                return removedrunner;
            }
            else
                return null;
        }

        //public void Simulate(Race race)
        //{
        //    int count = 4;

        //    for (int i = 0; i < count; i++)
        //    {
        //        race.CreateRunners(count, teamType.A);
        //        race.CreateRunners(count, teamType.B);
        //        race.CreateRunners(count, teamType.C);
        //        race.CreateRunners(count, teamType.D);
        //    }

        //}

        //public Runner GetMostAdvancedRunner()
        //{

        //}

        public List<Runner>? GetWinner()
        {
            if (runners == null || runners.Count == 0)
                return null;

            List<Runner> winners = new List<Runner>();

            for (int i = 0; i < runners.Count; i++) 
            {
                if (runners[i].GetPosition() >= GetMeta())
                    winners.Add(runners[i]);
            }
            return winners;
        }

        public Runner? RemoveRunnerWithName(string name)
        {
            if (runners == null)
                return null;

            for (int i = 0; i <= runners.Count; i++) 
            {
                if (runners[i].GetName() == name)
                {
                    Runner removedRunner = runners[i];
                    runners.RemoveAt(i);
                    return removedRunner;
                }
            }
            return null;
        }

        public void RemoveAllRunnerWithName(string name)
        {
            for (int i = runners.Count - 1; i >= 0; i--)
            {
                if (runners[i].GetName() == name)
                {
                    runners.RemoveAt(i);
                }
            }
            
        }

        public bool AllRunnersInTeamHaveFinished(teamType team)
        {
            for (int i = 0; i < runners.Count; i++)
            {
                var runner = runners[i];
                if (runner.GetTeam() == team && runner.GetPosition() < meta)
                {
                    return false;
                }
            }
            return true;
        }

        public teamType GetTeamAhead()
        {
            int A = 0;
            int B = 0;
            int C = 0;

            for (int i = 0; i < runners.Count; i++)
            {
                var runner = runners[i];
                if (runner.GetPosition() >= meta)
                {
                    if (runner._team == teamType.A)
                        A++;
                    else if (runner._team == teamType.B)
                        B++;
                    else if (runner._team == teamType.C)
                        C++;
                }
            }

            
            if (MayorDeTres(A, B, C) == A)
            {
                return teamType.A;
            }
            else if (MayorDeTres(A, B, C) == B)
            {
                return teamType.B;
            }
            else
            {
                return teamType.C;
            }
        }

        public static int MayorDeTres(int a, int b, int c)
        {
            return MayorDeDos(a, MayorDeDos(b, c));
        }

        public static int MayorDeDos(int a, int b)
        {
            if (a < b)
                return a;
            return b;
        }

        //refCount

        //simulacion de una carrera

        //clase runner

        //clase race
        //tiene lista de runners -> privada
        //List<Runner>? runners

        //si queremos darle la lista a otro: GetList():List<Runner>

        //getlistcount y getlistat

        //GetRunnerCount()int
        //GetRunnerAt(int index)Runner
        //CreateRunners(int)
        //-AddRunner(Runner runner) si es privada puedes no comprobar que sea null no hace falta ya que tengo el control. -> esta deberia ser publica
        //AddRunner es importante.

        //Buscar un corredor de carrera
        //GetRunnerWithName(name):Runner?

        //que primer parametro primero este relacionado con lo que pide la funcion

        //RemoveRunnerAt(int index)
        //RemoveRunnerWithName(string name)
        //RemoveAllRunnerWithName()

        //Runner: -age, -name, -velocity, -posicion (distancia desde salida, lo que llevo recorrido)
        //-team -> enum

        //Race
        //List<Runner> runners
        //meta double

        //Simulate() -> posicion le sume velocidad, con un random, o te muevas un random entre  y tu velocidad
        //GetMostAdvancedRunner():Runner
        //GetWinner():Runner? -> si posicion jugador es mayor o igual que meta

        //--> separar funciones de añade -> gets simples en otra clase queda mas limpio

        //clase Queries
        //GetWinner(race)

        //GetRunnerCountWithTeam(team, Race) -> puede no hacer falta
        //GetTeamWinner(Race):team
        //for ()
        //if (r[i].team = A && r[i].win) -> o tambien -> r[i]position < meta
        //nA++;
        //if (nA == nACount)
        //returnA;

        //GetTeamInHead():team
        //creas tres variables una para cada equipo, reales, las inicializo a 0

        //crear clase equipo para dividir los valores de la lista en los equipos, el que mayor valor tenga o se acerque al final gana. -> o puedo hacer un
        //for solo para hallar el mayor, pero guardando la posicion donde esta el valor mayor

        //papel oculto de la clase race es un arrapper de una lista (envoltorio)
    }
}
