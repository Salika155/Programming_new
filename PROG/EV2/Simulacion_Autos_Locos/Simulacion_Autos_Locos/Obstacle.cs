using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public abstract class Obstacle : RaceObject
    {
        public Obstacle(string name, double position) : base(name, position)
        {
        }

        public override bool IsAlive => true;

        public override ObjectType GetObjectType()
        {
            return ObjectType.Obstacle;
        }

        public override bool IsEnabled()
        {
            return true;
        }

        #region anotaciones
        //para este caso no se implementa aqui tampoco, como
        //es abstracta, las clases que hereden de esta clase
        //deberan implementar el metodo
        #endregion
        public abstract override void Simulate(IRace race);
       
    }
}
