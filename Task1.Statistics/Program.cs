using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] chisla = new int[10];

        for (int i = 0; i < chisla.Length; i++)
        {
            chisla[i] = rnd.Next(1, 101); // от 1 до 100 включительно
        }

        Console.WriteLine("Массив: " + string.Join(", ", chisla));

        long summa = 0;
        double proizvedenie = 1;
        int kolvoChet = 0;

        for (int i = 0; i < chisla.Length; i++)
        {
            summa += chisla[i];
            proizvedenie *= chisla[i];

            if (chisla[i] % 2 == 0)
            {
                kolvoChet++;
            }
        }

        double srednee = (double)summa / chisla.Length;

        int kolvoBolsheSrednego = 0;
        for (int i = 0; i < chisla.Length; i++)
        {
            if (chisla[i] > srednee)
            {
                kolvoBolsheSrednego++;
            }
        }

        Console.WriteLine("Сумма: " + summa);
        Console.WriteLine("Произведение: " + proizvedenie);
        Console.WriteLine("Чётных чисел: " + kolvoChet);
        Console.WriteLine("Больше среднего (" + srednee.ToString("F1") + "): " + kolvoBolsheSrednego);
    }
}