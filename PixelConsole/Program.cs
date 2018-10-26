using System;
using System.Drawing;
using System.Drawing.Printing;

namespace PixelConsole {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            GetColorByPixel();
            Console.ReadKey();
        }

        public static void GetColorByPixel() {
            using(Bitmap bmp = new Bitmap("../../../images/google.jpg")) {
                int x = bmp.Height / 2;
                int y = bmp.Width / 2;
                Color pixelColor = bmp.GetPixel(x, y);
                
                byte alpha = pixelColor.A;
                byte red = pixelColor.R;
                byte green = pixelColor.G;
                byte blue = pixelColor.B;

                Console.WriteLine("XY= " + x + "," + y);
                Console.WriteLine("ARGB= " + alpha + "," + red + "," + green + "," + blue);
            }
        }

    }
}
