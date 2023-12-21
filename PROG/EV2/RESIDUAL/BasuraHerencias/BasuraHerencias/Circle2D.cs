using System.Reflection.Metadata.Ecma335;

namespace BasuraHerencias
{
    public class Circle2D : ShapeWithArea
    {
        //-radius:double
        //+Set/Get/Radius

        private double _radius;

        public Circle2D(double radius, Point2D position, string name) : base(position, name)
        {
            //PUEDE SER PUBLIC
            _radius = radius;
            //pasarle el type para comprobar que sea circulo o hacerle un getshape type
        }

        public double GetRadius()
        {
            return _radius;
        }

        public void SetRadius(double radius)
        {
            _radius = radius;
        }

        public override ShapeType GetShapeType()
        {
            return ShapeType.CIRCLE2D;
        }

        //ESTO NO SIRVE
        //NO TENER OVERRIDE PARA HACER LO MISMO DOS VECES
        public new virtual void SetName(string name)
        {
            Name = name;
        }
    }
}
