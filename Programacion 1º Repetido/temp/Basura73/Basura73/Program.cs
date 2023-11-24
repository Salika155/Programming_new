namespace Basura73
{
    using UDK;
    using static UDK.RoomRT;

    namespace ConsoleApp1
    {
        internal class Program
        {

            public static void Filter(string fromPath, string toPath)
            {
                EditableImageHighPrecission source = new EditableImageHighPrecission(fromPath);
                EditableImageHighPrecission destination = new EditableImageHighPrecission(source.Width, source.Height);

                for (int y = 0; y < destination.Height; y++)
                {
                    for (int x = 0; x < destination.Width; x++)
                    {
                        rgba_f64 color = source[x, y];
                        //double aux = (color.r + color.g + color.b / 3);
                        //color.r = aux;
                        //color.g = aux;
                        //color.b = aux;

                        hsla_f64 hsl = color.ToHSL();
                        hsl.h = hsl.h + 0.8;
                        while (hsl.h >= 1)
                            hsl.h -= 1;
                        
                        destination[x, y] = hsl.ToRGBA();

                    }
                }

                destination.SaveToFile(toPath);
            }
            
            public static rgba_f64 GetMedia(EditableImageHighPrecission img, int x, int y)
            {
                rgba_f64 result;
                int r = 0;
                int g = 0;
                int b = 0;
                int count = 0;
               
                
                for (int y = 0; y < img.Height; y++)
                {
                    for (int x = 0; x < img.Width; x++)
                    {
                        r += img[x, x].r;
                        g += img[x, x].g;
                        b += img[x, x].b;






                    }

                }


            }


            static void Main(string[] args)
            {
                //Filter("C:\\Users\\carcarcor\\Downloads\\imagen1.png", "C:\\Users\\carcarcor\\Downloads\\imagen2.png");
                //Filter("C:\\Users\\carcarcor\\Downloads\\imagen3.png", "C:\\Users\\carcarcor\\Downloads\\imagen4.png");
                Filter("C:\\Users\\carcarcor\\Downloads\\ferrari.png", "C:\\Users\\carcarcor\\Downloads\\ferrari2.png");


            }
        }
    }
}