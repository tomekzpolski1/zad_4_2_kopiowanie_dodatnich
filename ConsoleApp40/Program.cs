using System;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = new int[10];
            Console.WriteLine("Podaj 10 liczb:");
            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = int.Parse(Console.ReadLine());
            }
           // int[] tab1 = {0, 1, -2, 3, 4, 5, 6, 7, 8, 9}; //jeżeli tablica zdefiniowana na "sztywno"
            int[] tab2 = new int [10];
           
            Console.WriteLine("Wyświetlanie pierwszej tablicy:");
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab1[i] + " ");
            }
            for (int i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] > 0)
                {
                    tab2[i] = tab1[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Wyświetlanie drugiej tablicy:");
            for (int i = 0; i < tab2.Length; i++)
            {
                Console.Write(tab2[i] + " ");
            }
        }
    }
}
