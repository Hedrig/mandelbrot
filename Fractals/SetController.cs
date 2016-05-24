using System.Drawing;
using Sets;

namespace FormMain
{
    class SetController
    {
        internal static float[,] GetMap(int width, int height, double scale, double a, double b, int iter_max)
        {
            return MapsWork.GetDepthMapParallel(width, height, scale, a, b, iter_max); 
        }
        internal static Bitmap DrawSet(float[,] map, int skip)
        {
            return ColorWork.FillPicture(map, skip);
        }
    }
}
