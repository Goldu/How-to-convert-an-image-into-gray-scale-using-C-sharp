using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Imageprocessing
{
    class Processing
    {
        public Processing()
        {

        }
        public static bool ConvertToGray(Bitmap B)
        {
            for (int i = 0; i < B.Width; i++)
                for (int j = 0; j < B.Height; j++)
                {
                    Color c1 = B.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    B.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            return true;
                }
        }
    }

