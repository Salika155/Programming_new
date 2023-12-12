

using System.Diagnostics.CodeAnalysis;

namespace Persona
{
    public class Student : Person
    {
        public long nia;

        public Student(long nia)
        {
            this.nia = nia;
        }

        public Student(string name, long nia) : base(name, GenderType.UNKNOWN)
        {
            this.nia = nia;
        }
    }
}
