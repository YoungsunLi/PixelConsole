using System.Drawing;
using Console = Colorful.Console;

namespace PixelConsole {
    class Program {
        static void Main(string[] args) {
            Bitmap bmp = new Bitmap("../../../images/c.png");
            int imageX = bmp.Width - 1;
            int imageY = bmp.Height - 1;
            for(int y = 0; y <= imageY; y++) {
                for(int x = 0; x < imageX; x++) {
                    Color pixelColor = bmp.GetPixel(x, y);
                    byte red = pixelColor.R;
                    byte green = pixelColor.G;
                    byte blue = pixelColor.B;
                    Console.Write("▇", Color.FromArgb(red, green, blue));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}