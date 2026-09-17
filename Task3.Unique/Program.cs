using System;
namespace Task3
{
    class Program
    {
        static bool IsExist(int[] a, int b)
        {
            
            foreach (int el in a)
            if (el==b) return true;
            return false;
        }
        static void Main()
        {
            int[] arr= new int[10];
            Random random = new Random();
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = random.Next(1, 6);
                System.Console.Write(string.Join(", ", arr));
                int j=0;
                int[] t=new int[0];
                foreach (int el in arr)
                if (!IsExist(t, el))
                {
                    Array.Resize(ref t, j+1);
                    t[j] = el;
                    j++;
                }
                System.Console.WriteLine(string.Join(", ", t));
            }
        }
    }
}
