using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum ColorType
{
    BLUE,
    WHITE,
    BLACK
}

namespace ClasesDelfin
{
    public class Delfin
    {
        public double size;
        private double life;
        public double lifecapacity;
        public string name;
        public ColorType color;

        //funcion de objeto
        public double GetLifePercent()
        {
            return life/10.0;

        }

        public bool IsAlive()
        {
            return life > 0.0;
        }

        public double GetLifePercentCapacity()
        {
            //return (life / lifecapacity) * 100;
            return (life / lifecapacity);
        }

        public void SetLife(double life)
        {
            //cada vez que ejecuta el this vale el valor del objeto, si el primero vale 100 la primera vez valdra 100 y la segunda si el segundo objeto vale 200 valdra ese valor.
            //this.life = life;
            if (life < 0.0)
                this.life = 0.0;
            else if (life > lifecapacity)
                this.life = lifecapacity;
            else
                this.life = life;

            //que reviente el programa
            //if (life < 0.0 || life > lifecapacity)
            //throw new exception("Maaaaal")
            //this.life = life;

            //que no haga nada
            //if (0.0 <= life && life <= lifecapacity)
            //this.life = life;

        }
    }
}
