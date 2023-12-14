

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

        public override void ExecuteTurn()
        {
            throw new NotImplementedException();
        }

        public override string GetFullName()
        {
            return "<STUDENT>" + Name + "</STUDENT>";
        }
    }
}
