using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class Graveyard
    {
        private List<Person> _personList = new List<Person>();

        //public int PersonCount
        //{
        //    get
        //    {
        //        return _personList.Count;
        //    }
        //}

        public int GetPersonCount()
        {
            return _personList.Count;
        }

        //public int PersonCount => GetPersonCount();

        public int PersonCount
        {
            get
            {
                return GetPersonCount();
            }
        }

        //removepersonat
        //addperson
        //getpersonat

        public void AddPerson(Person p)
        {
            if (p == null)
                return;
            _personList.Add(p);
        }

        public void RemovePersonAt(int index)
        {
            if (index == null)
                return;
            _personList.RemoveAt(index);
        }

        public Person GetPersonAt(int index)
        {
            for (int i = 0; i < _personList.Count; i++)
            {

            }
        }

        
    }
}
