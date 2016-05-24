using System.Threading.Tasks;
namespace Sets
{
    /// <summary>
    /// Класс, работающий с картами высот.
    /// </summary>
    public class MapsWork
    {
        /// <summary>
        /// Создаёт "карту глубин" - двумерный массив, каждой точке которого соответствуют некоторое значение, равное количеству
        /// пройденных итераций для этой точки.
        /// </summary>
        /// <param name="width">ширина проверяемой области.</param>
        /// <param name="height">высота проверяемой области.</param>
        /// <param name="a">координата X по оси абсцисс комплексной координатной плоскости.</param>
        /// <param name="b">координата Y по оси ординат комплексной координатной плоскости.</param>
        /// <param name="scale">масштаб.</param>
        /// <param name="iter_max">максимум итераций для завершения проверки.</param>
        public static float[,] GetDepthMap(int width, int height, double scale, double a, double b, int iter_max)
        {
            float[,] depthmap = new float[width, height];
            width = width >> 1; height = height >> 1; // Ширину и высоту делим на два, чтобы не вводить новых переменных
            double cury; // Текущее значение x хранить нет надобности - мы его постоянно пересчитываем
            for (int y = -height; y < height; y++)
            {
                // Координаты проверяемой точки вычисляем с использованием координат центральной точки
                cury = y / scale + b;
                for (int x = -width; x < width; x++)
                    // При помощи метода узнаём количеcтво затраченных итераций и помещаем его в карту
                    depthmap[x + width, y + height] = MandelSet.DoesBelong(x / scale + a, cury, iter_max);
            }
            return depthmap;
        }

        /// <summary>
        /// Создаёт "карту глубин" - двумерный массив, каждой точке которого соответствуют некоторое значение, равное количеству
        /// пройденных итераций для этой точки.
        /// </summary>
        /// <param name="width">ширина проверяемой области.</param>
        /// <param name="height">высота проверяемой области.</param>
        /// <param name="a">координата X по оси абсцисс комплексной координатной плоскости.</param>
        /// <param name="b">координата Y по оси ординат комплексной координатной плоскости.</param>
        /// <param name="scale">масштаб.</param>
        /// <param name="iter_max">максимум итераций для завершения проверки.</param>
        public static float[,] GetDepthMapParallel(int width, int height, double scale, double a, double b, int iter_max)
        {
            float[,] depthmap = new float[width, height];
            double[] cury = new double[height]; // Текущее значение x хранить нет надобности - мы его постоянно пересчитываем
            width = width >> 1; height = height >> 1; // Ширину и высоту делим на два, чтобы не вводить новых переменных
            Parallel.For(-height, height, y =>
            {
                // Координаты проверяемой точки вычисляем с использованием координат центральной точки
                cury[y + height] = y / scale + b;
                 for (int x = -width; x < width; x++)
                    // При помощи метода узнаём количеcтво затраченных итераций и помещаем его в карту
                    depthmap[x + width, y + height] = MandelSet.DoesBelong(x / scale + a, cury[y + height], iter_max);
            });
            return depthmap;
        }
    }
}