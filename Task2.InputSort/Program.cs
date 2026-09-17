using System;

class Program
{
    static void Main()
    {
        int n = 0;
        bool vvedeno = false;

        while (!vvedeno)
        {
            Console.Write("Введите количество элементов: ");
            string stroka = Console.ReadLine();

            if (int.TryParse(stroka, out n) && n > 0)
            {
                vvedeno = true;
            }
            else
            {
                Console.WriteLine("Число должно быть больше нуля, попробуйте ещё раз.");
            }
        }

        int[] massiv = new int[n];

        for (int i = 0; i < n; i++)
        {
            bool elementVveden = false;

            while (!elementVveden)
            {
                Console.Write("Элемент [" + i + "]: ");
                try
                {
                    massiv[i] = Convert.ToInt32(Console.ReadLine());
                    elementVveden = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Это не число, попробуйте снова.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Число слишком большое, попробуйте снова.");
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Исходный массив:  " + string.Join(", ", massiv));

        int[] obratnyi = new int[n];
        for (int i = 0; i < n; i++)
        {
            obratnyi[i] = massiv[n - 1 - i];
        }
        Console.WriteLine("Обратный порядок: " + string.Join(", ", obratnyi));

        int[] otsortirovannyi = (int[])massiv.Clone();
        Array.Sort(otsortirovannyi);
        Console.WriteLine("Отсортированный:  " + string.Join(", ", otsortirovannyi));

        int maximum = massiv[0];
        int minimum = massiv[0];

        for (int i = 1; i < n; i++)
        {
            if (massiv[i] > maximum) maximum = massiv[i];
            if (massiv[i] < minimum) minimum = massiv[i];
        }

        Console.WriteLine("Максимум: " + maximum);
        Console.WriteLine("Минимум: " + minimum);
    }
}