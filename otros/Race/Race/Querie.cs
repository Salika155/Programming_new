using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    public class Querie
    {
        public void GetWinner(Race race)
        {
            

        }

        public int GetRunnerCountWithTeam(teamType team, Race race)
        {
            int count = 0;

            foreach (var runner in race.GetRunner())
            {
                if (runner.GetTeam() == team)
                {
                    count++;
                }
            }
            return count;
        }

        //public teamType GetTeamWinner(Race race) 
        //{

        //}

        //public teamType GetTeamInHead()
        //{

        //}


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
