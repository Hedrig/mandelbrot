using System;
using FifthTask;

namespace Sets
{
    /// <summary>
    /// Предоставляет набор методов, позволяющих определить принадлежность точки к множеству Мандельброта.
    /// </summary>
    public static class MandelSet
    {
        /// <summary>
        /// Определяет, принадлежит ли точка на комплексной системе координат множеству Мандельброта.
        /// </summary>
        /// <param name="point">точка на комплексной системе координат.</param>
        /// <param name="maxiter">максимум итераций для проверки.</param>
        /// <returns>количество пройденных итераций.</returns>
        public static float DoesBelong(Complex point, int maxiter)
        {
            // Для ускорения алгоритма проверяем точку по уравнению кардиоиды
            // Команд всего ничего, так что много времени это не отнимает
            if (BelongToCardid(point.Re, point.Im))
                return maxiter;
            Complex temp = point;  // z = c
                                   // Самые "тяжёлые" по времени выполнения операции - это операции с комплексными числами.
                                   // Т.к. считаем оптимизированный модуль без взятия корня, метод из библиотеки не подойдёт
            for (int iterations = 0; iterations < maxiter; iterations++)
            {
                if (temp.Re * temp.Re + temp.Im * temp.Im > 4)
                {
                    double log2 = Math.Log(2);
                    return (float)(iterations + 1 - Math.Log(Math.Log(temp.Re * temp.Re + temp.Im * temp.Im) / (log2 + log2)) / log2);
                }
                temp = temp * temp + point; // z = z^2 + c
            }
            return maxiter;
        }

        
        /// <summary>
        /// Определяет, принадлежит ли точка на комплексной системе координат множеству Мандельброта.
        /// </summary>
        /// <param name="x">координата точки по оси абсцисс.</param>
        /// <param name="y">координата точки по оси ординат.</param>
        /// <param name="maxiter">максимум итераций для проверки.</param>
        /// <returns>количество пройденных итераций.</returns>
        public static float DoesBelong(double x, double y, int maxiter)
        {
            return DoesBelong(new Complex(x, y), maxiter);
        }

        /// <summary>
        /// Определяет, принадлежит ли точка главной кардиоиде множества Мандельброта.
        /// </summary>
        /// <param name="x">координата точки по оси абсцисс.</param>
        /// <param name="y">координата точки по оси ординат.</param>
        private static bool BelongToCardid(double x, double y)
        {
            x -= 0.25; y *= y;
            double q = x * x + y + x; // Обошлись без квадратного корня и заодно ускорили выполнение общего алгоритма
            return (q - x) * (q + q + q + q) < y;
        }
    }
}