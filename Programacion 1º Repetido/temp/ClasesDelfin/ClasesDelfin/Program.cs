using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ClasesDelfin
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Delfin d1;
            //Delfin d2;

            //d1 = new Delfin(1000, 8000);
            //d1.size = 140.0;
            ////d1.life = 30.0
            //d1.name = "Eustaquio";
            //d1.color = ColorType.BLACK;


            //d2 = new Delfin(1000, 8000);
            //d2.size = 60.0;
            ////d2.life = 50.0
            //d2.name = "Parkour";
            //d2.color = ColorType.WHITE;

            //Delfin d3;
            //d3 = d1;
            ////d3.life = 80.0
            ////crear proyecto nuevo y empezamos a hacer esto

            ////preguntar porcentaje vida delfin
            ////crear variable para almacenar vida y preguntarle a la funcion para obtener esa vida.

            //double l;
            //l = d1.GetLifePercent();
            //double l2;
            //l2 = d2.GetLifePercent();

            ////preguntar si delfin esta vivo
            //bool b1;
            //b1 = d1.IsAlive();

            ////d1.life = 100.0;

            //d1.SetLife1(30.0);
            //Console.WriteLine(d1.GetLife());

            //d2.SetLife2(50.0);

            //d3.SetLife3(80.0);

            ////List<int> l;
            ////l = new List<int>();
            ////l.Add(40);
            ////l.Add(-10);
            ////l.Remove(2); //borra el primer 2 que haya en la lista
            ////l.RemoveAt(2); //borra lo que haya en la posicion 2
            ////l[0] = 60; //[60,10] //cambia elemento 0 por 60
            ////l[i + 0] = 3; //[60, 3] sustituye elemento en posic 2 por 3
            ////int n = l.Count; 2 //elementos que hay en la lista
            ////l.Insert(1, -20); -> [60, -20, 3]
            ////l.Clear(); -> limpia la lista
            ////l[1]=l[2] -> [60, -20, 3] -> [60, 3, 3]

            ////int[] a;
            ////a = new int[4]; //-> crear array de 4 elementos [0, 0, 0, 0] ->para array tienes que indicar numero de elementos, en lista no
            ////a[3] = -10;     // -> [0, 0, 0, -10]
            ////a[0] = a[3];    //[-10, 0, 0, -10]
            ////int n = a.Length; //4 elementos, te dice cuantos hay
            ////int[] b = a; //b apunta a array a

            ////FUNCION que le paso lista de strings y devuelve el numero de elementos que hay en la lista
            ////
            ///

            Character c1 = new Character();
            Character c2 = c1;
            c1.name = "Poli1";
            c1.type = CharacterType.POLICE;

            
            List<Character> list = new List<Character>();
            list.Add(c1);

            c1 = null;
            c2 = null;
            //no desapareceria porque ahora el objeto apunta a la lista
            //c1 sigue siendo un numero, y cuando creas la lista haces que esta apunte al numero para añadirlo->apunta a un objeto que
            list.Add(new Character());
            list[1].name = "Ana";
            list[0].name = list[1].name;
            list.Add(list[0]);





        }
    }
}