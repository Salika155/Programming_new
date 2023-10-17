using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDelfin
{
    internal class CharacterUtils
    {
        //funcion que yo le paso una lista de personajes y un string, que es un nombre Ana, quiero que me diga si hay algun personajes que se llame Ana en la lista

        public static bool ContainsName(List<Character> characters, string name)
        {
            if (characters == null)
                return false;

            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].name == name)
                    return true;
            }
            return false;

        }

        //funcion que le paso una lista y un nombre, quiero que me devuelva el primer objeto con ese nombre que este
        //en la lista

        public Character? ContainsObject(List<Character> characters, string name)
        { 
            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].name == name)
                    return characters[i];
            }
            return null;
        }

        //funcion que le paso una lista de personajes, y me devuelve si hay un duplicado

        public bool ContainDuplicate(List<Character> characters)
        {
            if (characters == null)
                return false;

            for(int i = 0; i < characters.Count; i++)
            {
                for (int j = i +1; j < characters.Count; j++)
                {
                    if (characters[i].name == characters[j].name)
                        return true;
                }
            }
            return false;
        }

    }
}
