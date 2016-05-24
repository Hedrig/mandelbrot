using System.Collections.Generic;

namespace DataStorage
{
    /*
     * В приложении для закраски изображённого множества используется градиент по опорным точкам.
     * Эти точки хранятся в отдельном классе, благодаря чему к ним имеют доступ как форма, так и реализация проекта. 
     */
    /// <summary>
    /// Структура, хранящая значение глубины и соотвествующий цвет.
    /// </summary>
    public class ColorPoint
    {
        /// <summary>
        /// Создаёт новый экземпляр точки с заданными значениями глубины и цветовых составляющих.
        /// </summary>
        /// <param name="depth">глубина новой точки.</param>
        /// <param name="red">красная часть цвета.</param>
        /// <param name="green">зелёная часть цвета.</param>
        /// <param name="blue">синяя часть цвета.</param>
        internal ColorPoint(int depth, byte red, byte green, byte blue)
        {
            Depth = depth; Red = red; Green = green; Blue = blue;
        }

        /// <summary>
        /// Получает или задаёт глубину для этой точки.
        /// </summary>
        public int Depth { get; set; }

        /// <summary>
        /// Получает или задаёт значение красного компонента этой точки.
        /// </summary>
        public byte Red { get; set; }

        /// <summary>
        /// Получает или задаёт значение зелёного компонента этой точки.
        /// </summary>
        public byte Green { get; set; }

        /// <summary>
        /// Получает или задаёт значение синего компонента этой точки.
        /// </summary>
        public byte Blue { get; set; }
    }
    /// <summary>
    /// Класс для хранения опорных точек, по которым будет строиться изображение.
    /// </summary>
    public static class PointStorage
    {
        static PointStorage()
        {
            Points = new List<ColorPoint>();
        }



        /// <summary>
        /// Количество точек, находящихся в хранилище.
        /// </summary>
        public static int Count { get { return Points.Count; } }

        /// <summary>
        /// Список точек, находящихся в хранилище.
        /// </summary>
        public static List<ColorPoint> Points { get; private set; }

        /// <summary>
        /// Добавляет в список новую запись.
        /// </summary>
        public static void AddPoint(int depth, byte red, byte green, byte blue)
        {
            // Сортировка производится при вставке элемента
            if (Count != 0) 
            {
                for (int i = 0; i < Count; i++)
                    if (depth < Points[i].Depth)
                    {
                        Points.Insert(i, new ColorPoint(depth, red, green, blue));
                        return;
                    }
                    else // Если такая глубина уже существует - обновляем цвет соответствующей точки
                        if (depth == Points[i].Depth)
                        {
                            Points[i].Red = red;
                            Points[i].Green = green;
                            Points[i].Blue = blue;
                            return;
                        }
            }
            Points.Add(new ColorPoint(depth, red, green, blue));
        }

        /// <summary>
        /// Определяет, содержится ли запись в списке.
        /// </summary>
        public static bool DepthContains(int depth)
        { // Поиск выполняем по глубине, т.к. она не повторяется
            int left = 0, right = Count - 1, mid = Count / 2;
            while (true)
            {
                if (depth > Points[mid].Depth) left = mid;
                else if (depth < Points[mid].Depth) right = mid;
                else return true;
                if ((mid == right) || (mid == left)) return false;
                mid = (right - left) / 2;
            }
        }

        /// <summary>
        /// Удаляет запись с указанным индексом.
        /// </summary>
        public static void RemoveItem(int index)
        {
            Points.RemoveAt(index);
        }

        /// <summary>
        /// Очищает хранилище точек. 
        /// </summary>
        public static void Clear()
        {
            Points.Clear();
        }
    }
}
