using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraDeDios
{

    public delegate int ComparatorDelegate<T>(T n1, T n2);
    public class Utils
    {
        public static void Swap<T>(ref T a, ref T b)
        {

            T aux = a;
            a = b;
            b = aux;
        }

        public static void Sort<T>(T[] array, ComparatorDelegate<T> comparer)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer(array[i], array[j]) < 0)
                    {
                        Swap(ref array[i],ref array[j]);
                        
                    }
                }
            }
        }
    }
}

//CUANDO creas un objeto en memoria se guarda en el heap, y un struct, que es como una variable
//se guardaria en el stack, que es de tamaño fijo, no como el heap  que es variable
//En el stack se copia la variable de los parametros de la funcion, el resultado, y la referencia
//cuando es struc no creas objetos, estas apuntando al stack
//si una variable es parte de un objeto que se encuentra en el heap, esta variable y clase siguen estando
//dentro del heap
//referencetypes y valuetypes
//struct como un entero donde mete cosas a 0 directamenjte, son menos ciclos de reloj y no reserva
//espacio en el heap de lo que puede ser una nueva clase,
//diferenciar entre si querer hacer una copia o que apunten al mismo sitio

//clase inmutable y que no herede de nadie
//class, struct y record
record Student(string Name, int Age)
{
    int Curso { get; set; }
}
//esencia de que todos sus parametros sean readonly
//esto es un objeto referenciado creado en el heap

//clases pueden heredar y implementar interfaces
//struct no pueden heredar pero si implementar
//record 
//struct creacion variable temporal o que este dentro de otro objeto

//void YerkoQuiereAEnrique()
//{
//    for (int i = 0; i <= 0; i--)
//    {
//        Beso b = new BesoEnLaBoca();
//          para el caso BesoEnLaBoca hereda de Beso
//              SE CREA en algun lugar del heap -> b apunta a ese heap
//              tendra 3 variables, la de la funcion y lugar de memoria, la del resultado del for, y la de la propia b
//EN ACABAR el proceso de B, b apuntará a null, y en teoría se destruiria
//runtime de C# para funcionamiento programas -> el objeto no va a microprocesador, sino codigo legible por runtime 
//la app se lo pide al runtime, el runtime se lo pide al S.O. el S.O. se lo devuelve al runtime, y el runtime se lo devuelve a C#
//cuando el runtime dice a c# de borrar el objeto, este no es borrado, es dejado en una minicache por si en algun momento futuro se necesita
//lo mete en una lista de objetos que estan muertos llamada Garbage Collector
//App --> Runtime --> SO --> Runtime --> SO (Garbage Collector) -> pool (contenedor temporal de memoria para uso temporal)
//    }
//}


//esencia autoreference counting que algo se vaya generando y destruya cuando no haga falta
//no controlas cuando se destruye un objeto no puedes controlar el destructor

//nODE <t> Parent {get; set;}
//bool IsRoot {get;}
//bool IsLeaf{get}
//int ChildCount{get}
//int Level {get}
//node <T> Root {get;set}

//int GetLevel()
//{
// if (_parent == null)
//return 0;
//return _parent.GetLevel()+1;

//Node<T> GetRoot()
//{
//if (_parent == null)
//return this;
//return _parent.GetRoot();
//}

//Node<T> GetChildAt(int index)

//void Unlink o Detach()
//{_parent.Remove(this) (tiene que ser private) }

//void AddChild(Node<T> child)







