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
        private double lifeCapacity;
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
            return (life / lifeCapacity);
        }

        

        public Delfin()
        {
            
        }

        public double GetLife(double lifecapacity) 
        {
            return life;
        }

        //implementar las tres funciones setlife1, 2 y 3 y probarlas
        public void SetLife1(double life)
        {
            //cada vez que ejecuta el this vale el valor del objeto, si el primero vale 100 la primera vez valdra 100 y la segunda si el segundo objeto vale 200 valdra ese valor.
            //this.life = life;
            if (life < 0.0)
                this.life = 0.0;
            else if (life > lifeCapacity)
                this.life = lifeCapacity;
            else
                this.life = life;
        }

        public void SetLife2(double life)
        {
            //que reviente el programa
            if (life < 0.0 || life > lifeCapacity)
                throw new Exception("No funciona bro, lo petaste");
            this.life = life;
        }

        public void SetLife3(double life) 
        {
            //que no haga nada
            if (0.0 <= life && life <= lifeCapacity)
                this.life = life;
        }

    }
}
