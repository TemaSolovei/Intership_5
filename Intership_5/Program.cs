using System;

namespace Intership_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N; // N - порядок матрицы
            double[,] mas; // mas - массив
            double max; // max - максимальный элемент

            N = checkInt("Пожалуйста, введите разрядность матрицы: ");
            mas = new double[N,N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Строка №{0}", i+1);
                for (int j = 0; j < N; j++)
                {
                   mas[i,j] = checkDouble("Пожалуйста, введите следующий элемент матрицы: ");
                }
            }

            max = mas[0, 0];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((((j <= i) && (j <= N - i - 1)) || ((j >= i) && (j >= N - i - 1))) && (max < mas[i, j]))
                    {
                        max = mas[i, j];
                    }
                }
            }

            Console.WriteLine("Максимальный элемент = {0}", max);
        }

        static int checkInt(string message)
        {
            int result; // result - проверенная переменная
            bool ok; // Проверка ввода

            do
            {
                Console.Write(message);
                ok = int.TryParse(Console.ReadLine(), out result);
                if (!ok) Console.WriteLine("Ошибка ввода, введите вещественное число!");
                if (result <= 0) Console.WriteLine("Ошибка! Порядок матрицы должен быть больше 0!");
            } while ((!ok) || (result <= 0));

            return result;
        }

        static double checkDouble(string message)
        {
            double result; // result - проверенная переменная
            bool ok; // Проверка ввода

            do
            {
                Console.Write(message);
                ok = double.TryParse(Console.ReadLine(), out result);
                if (!ok) Console.WriteLine("Ошибка ввода, введите вещественное число!");
            } while (!ok);

            return result;
        }
    }
}
