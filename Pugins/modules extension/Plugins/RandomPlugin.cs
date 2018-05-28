using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Plugins
{
    class RandomPlugin : IPlugin
    {
        public string Name => "Random Transform ha-Ha";
        public string Version => "1.0";
        public string Author => "Lanin VV";

        public void Transform(IMainApp application)
        {
            Bitmap bitmap = application.Image;
            Random rand = new Random(DateTime.Now.Millisecond);
            int pixels = (int)(0.1 * bitmap.Width * bitmap.Height);

            for (int i = 0; i < pixels; ++i)
                bitmap.SetPixel(rand.Next(bitmap.Width - 1), rand.Next(bitmap.Height), Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)));

            application.Image = bitmap;

        }
    }
}
