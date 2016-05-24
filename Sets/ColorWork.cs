using System.Drawing;
using DataStorage;

namespace Sets
{
    /// <summary>
    /// Класс для работы с изображением и его заполнением.
    /// </summary>
    public class ColorWork
    {
        /// <summary>
        /// На основе карты глубин возвращает построенное изображение в формате System.Drawing.Bitmap.
        /// </summary>
        /// <param name="map">карта.</param>
        /// <param name="iter_min">на это значение уменьшается каждая запись в карте.</param>
        public static Bitmap FillPicture(float[,] map, int skip)
        {
            if (skip > 0)
            {
                float[,] newmap = new float[map.GetLength(0), map.GetLength(1)]; // карту копируем в новый массив, дабы не портить
                for (int x = 0; x < map.GetLength(0); x++)
                    for (int y = 0; y < map.GetLength(1); y++) // Каждую запись в карте уменьшаем на заданное (обычно минимальное) число итераций.
                        if ((map[x, y] > PointStorage.Points[0].Depth) && (map[x, y] < PointStorage.Points[PointStorage.Count - 1].Depth))
                            newmap[x, y] = map[x, y] - skip;
                        else
                            newmap[x, y] = map[x, y];
                return FillPicture(newmap);
            }
            else return FillPicture(map);
        }

        /// <summary>
        /// На основе карты глубин возвращает построенное изображение в формате System.Drawing.Bitmap.
        /// </summary>
        /// <param name="map">карта.</param>
        private static Bitmap FillPicture(float[,] map)
        {
            ColorPoint[] pts = PointStorage.Points.ToArray();
            int width = map.GetLength(0), h = map.GetLength(1);
            Bitmap img = new Bitmap(width, h);
            for (int y = 0; y < h; y++)
                for (int x = 0; x < width; x++) // По карте и опорным точкам закрашиваем пиксели
                    img.SetPixel(x, y, GetColor(map[x, y], pts));
            return img;
        }

        /// <summary>
        /// Возвращает цвет, которым нужно закрасить данную точку, с использованием косинусной интерполяции.
        /// </summary>
        /// <param name="value">значение глубины данной точки.</param>
        /// <returns>цвет.</returns>
        private static Color GetColor(float value, ColorPoint[] points)
        {
            // Находим, между какими двумя ближайшими точками находится данное значение глубины
            // d1 - номер точки, значение глубины которой меньше данного, d2 - больше или равно
            // Идём по массиву, ищем первый больший или равный элемент
            // Предыдущий элемент волшебным образом оказывается ближайшим меньшим
            int y1, d1 = 0, d2 = 1;
            for (; value > points[d2].Depth; d2++) ;
            d1 = d2 - 1;
            y1 = points[d1].Depth;
            // После этого вычисляем коэффициент, от которого будет зависеть цвет
            double k = System.Math.Cos(System.Math.PI * (value - y1) / (points[d2].Depth - y1));
            return Color.FromArgb((int)((points[d1].Red + points[d2].Red + k * (points[d1].Red - points[d2].Red)) / 2),
                                  (int)((points[d1].Green + points[d2].Green + k * (points[d1].Green - points[d2].Green)) / 2),
                                  (int)((points[d1].Blue + points[d2].Blue + k * (points[d1].Blue - points[d2].Blue)) / 2));
        }
    }
}
