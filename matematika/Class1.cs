
using System;
namespace Consol
{
    class Primer1
    {
        public Primer1()
        {
            static void Main(string[] args)
            {
                int a = 0;
                int[] massiv = new int[10] { 7, 1, 2, 8, 7, 4, 0, 1, 7, 7 }; // объявляем массив
                Console.Write("Введите искомое число: ");
                int b = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < massiv.Length; i++)  // цикл. Проходим весь массив
                {
                    if (massiv[i] == b)
                        a++;
                }
                Console.WriteLine("число " + b + " встречается в массиве " + a + " раз(а)");     // вывод задачи      

                Console.WriteLine("массив : ");
                for (int i = 0; i < massiv.Length; i++)
                    Console.Write(" " + massiv[i]);      // вывод всего массива
                Console.ReadKey();
            }
        }
    }
}
