using DAM;

namespace ImageFilters
{
    internal class Program
    {
        public static void Test1()
        {
           string path = "C:\\Users\\alumno\\Desktop\\images\\test.jpg";
           Image img = new Image();
           img.Config(800, 600, new RGBA(1.0, 0.0, 0.0, 1.0));
           Drawing.FillRectangle(img, new RGBA(0.0, 1.0, 1.0, 1.0), 400, 500, 30, 50);
           img.Save(path);

          
        }

        public static void Test2()
        {
            string path = "C:\\Users\\alumno\\Desktop\\images\\";
            string in_path = path + "100.jpg";
            string out_path = path + "bw.jpg";
            Image img = new Image();
            img.Load(in_path);
            Drawing.FillBlack(img);
            img.Save(out_path);
        }
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test4();
        }

        public static void Test4()
        {
            string path = "C:\\Users\\alumno\\Desktop\\images\\ferrari.jpg";
            string in_path = path + "ferrari.jpg";
            string out_path = path + "ferraricolor";
            Image img = new Image();
            Image des = new Image();
            img.Load(in_path);
            des.Config(img.Width, img.Height);
            Drawing.RotateHue(img, des, 0, 1);
            des.Save(out_path);
        }
        //hacer en blanco y negro, quitando una banda de colores, y invirtiendo la imagen//
       

        
    }
}