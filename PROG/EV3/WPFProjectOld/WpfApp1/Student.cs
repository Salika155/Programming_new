using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Student
    {
        private long _id;
        private string _name;
        private int _age;
        private string _description;

        public long Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }




    }
}
