using DAM;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tom_Jerry
{
    public enum CharacterType
    {
        CAT,
        MOUSE
    }
    public class Character

    {
        
        public CharacterType Type;
        public float x;
        public float y;
        public float width;
        public float height;
        public float r;
        public float g;
        public float b;
        public float a;
        public DAM.Image image;
        public void Render(ICanvas canvas /*float arw, float ar*/)
        {
            canvas.FillRectangle(this.x - (width / 2), this.y - (height / 2), this.width, this.height, this.r, this.g, this.b, this.a);
        }

    }
}
