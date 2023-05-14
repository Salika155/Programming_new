using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BuscaminasBiblio
{
     public interface IBoard
     {
        // Javi: Te falta por documentar lo que retorna cada función así como lo parámetros de entrada de las funciones
        //Anotaciones para mi: al ser una interfaz que implementa los metodos en otra clase, se cierran sin cuerpo ya que estas se implementaran en otro lugar.

        /// <summary>
        /// Obtiene el with del tablero
        /// </summary>
        /// <returns></returns>
        int GetWidth();

        /// <summary>
        /// Obtiene el height del tablero
        /// </summary>
        /// <returns></returns>
        int GetHeight();

        /// <summary>
        /// Genera el teclado, pasandole el with y height para las dimensiones que terminara teniendo
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        void CreateBoard(int width, int height);

        /// <summary>
        /// Inicia el juego poniendo en el tablero las bombas, en las posiciones x e y generadas de manera aleatoria
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="bombCount"></param>
        void Init(int x, int y, int bombCount);

        /// <summary>
        /// Funcion que te dice si la casilla en la que se encuentra tiene una bomba o no
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        bool IsBombAt(int x, int y);

        /// <summary>
        /// Funcion para saber si en la proximidad a una celda +1 o -1 en x o y, se encuentra otra bomba
        /// Se le pasa un x e y para la posicion de la celda y bomba.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int GetBombProximity(int x, int y);

        /// <summary>
        /// Funcion para poner una bandera cuando se le indique en la casiila en la que se encuentra en jugador (x, y)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void PutFlagAt(int x, int y);

        /// <summary>
        /// Funcion que pregunta si en esa casilla hay una bandera ya, para si no hay ponerla si se la llama
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        bool IsFlagAt(int x, int y);

        /// <summary>
        /// Funcion que se le pregunta si en la casilla hay una bandera, y si es asi la quita.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void DeleteFlagAt(int x, int y);

        /// <summary>
        /// Funcion que pregunta a una celda si esta abierta o no.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        bool IsOpen(int x, int y);

        /// <summary>
        /// Funcion por la cual si esa celda no esta abierta, la abre para ver el contenido que tiene
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        bool OpenCell(int x, int y);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        bool HasWin(int x, int y)
        {
            throw new NotImplementedException();
        }
      }   
}
