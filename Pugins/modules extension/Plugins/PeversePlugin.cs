using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Plugins
{
    class PeversePlugin : IPlugin
    {
        public string Name => "Reverse";
        public string Version => "1.0";
        public string Author => "Lanin VV";

        public void Transform(IMainApp application)
        {
            Bitmap bitmap = application.Image;

            for (int i = 0; i < bitmap.Width; ++i)
                for (int j = 0; j < bitmap.Height / 2; ++j)
                {
                    Color color = bitmap.GetPixel(i, j);
                    bitmap.SetPixel(i, j, bitmap.GetPixel(i, bitmap.Height - j - 1));
                    bitmap.SetPixel(i, bitmap.Height - j - 1, color);
                }

            application.Image = bitmap;
        }
    }
}