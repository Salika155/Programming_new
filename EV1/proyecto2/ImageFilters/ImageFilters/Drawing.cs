using DAM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    internal class Drawing
    {
        public static void FillRectangle(Image image, RGBA color, int width, int heigh, int x, int y)
        {
            for (int h = y; h < heigh + y; h++)
            {
                for (int w = x; w < width + x; w++)
                {
                    image.SetPixel(w, h, color);
                }
            }
        }
        public static void FillBlack(Image img)
        {
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    RGBA value = img.GetPixelAt(x, y);
                    double bw = (value.r + value.g + value.b) / 3;
                    RGBA nuevoc = new RGBA(bw, bw, bw, 1.0);
                    img.SetPixel(x, y, nuevoc);
                }

            }

        }

        public static double Saturate(double value, double min, double max)
        {
             if (value < min)
                 return min;
             if (value > max)
                 return max;
             return value;
        }

        public static double Circular(double value, double min, double max)
        {
                double dis = max - min;
                while (value > max)
                {
                    value -= dis;
                }
                while (value < min)
                {
                    value += dis;
                }
                return value;
        }
        public static void RotateHue(Image img, Image des, double hueIncrement)
        {
            RGBA color = new RGBA();
            HSLA hsla = new HSLA();

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    color = img.GetPixelAt(x, y);
                    hsla = color.ToHSL();
                    hsla.h += hueIncrement;
                    hsla.h = Circular(hsla.h, 0, 1);
                    color = hsla.ToRGBA();
                    des.SetPixel(x, y, color);



                }
            }
            
            

        }

    }  
 }
