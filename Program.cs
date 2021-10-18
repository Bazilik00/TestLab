using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_1._1
{
    class Array
    {
        private int[] array;

        public Array(int n)//конструктор
        {
            array = new int[n];

        }

        ~Array()//деструктор
        {
            Console.WriteLine("Деструктор");//деструктор вызывается автоматически
        }//когда он будет вызван произойдет "сборка мусора" встроенная функция в с#

        public void RandomArray(int min, int max)//метод заполнения массива случайнымим числами
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(max - min + 1) + min;
        }

        public void ShowArray()//метод чтения массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");

        }
        public void ReadArray(int num, int i)//метод записи
        {
            if ((i > array.Length) || (i < 0))
            {
                Console.WriteLine("Индекс вышел за границы массива");
            }
            else
            {
                array[i] = num;
            }
        }


        public void TransferArray()//метод переноса первых элементов
        {
            Console.Write("Введите сколько первых элементов вы хотите перенести в конец: ");
            int f = Convert.ToInt32(Console.ReadLine());
            int[] numbers2 = new int[array.Length +1];
            // копируем из array с 0-го индекса f элементов 
            // и поместим их в массив numbers2, начиная с 0-го индекса
            //array.CopyTo( numbers2, f);
            Console.WriteLine(numbers2.Rank);
            Console.WriteLine(numbers2.Length);
            for (int i = 0; i < f-1; i++)
            {
                array[i] = numbers2[f-1 +i];
            }
            numbers2.CopyTo(array, 0);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int min = Convert.ToInt32 (- 135);
            int max = Convert.ToInt32(175); 

            Console.Write("Введите размер массива: ");
            Array A = new Array(int.Parse(Console.ReadLine()));
            A.RandomArray(min, max); // Заполняем случайными числами массив в заданном диапазоне
            A.ShowArray(); // Вывод содержимого массива на экран




            int q = 1;
            while (q != 5)
            {
                Console.WriteLine("\n" +
                     "\n1. Массив из случайных чисел" +
                     "\n2. Удалить все элементы, первая и последняя цифра которых четная" +
                     "\n3. Вставить число К1 и К2 " +
                     "\n4. Перенести первые k элементов в конец" +
                     "\n5. Выход из программы"
                      );
                Console.Write("\n ==> ");

                q = Convert.ToInt32(Console.ReadLine());
                switch (q)
                {
                    case 1:
                        A.RandomArray(min, max);
                        A.ShowArray();
                        break;
                    case 2:
                    
                        break;
                    case 3:
                      
                        break;
                    case 4: 
                        A.TransferArray();
                        A.ShowArray();
                        break;
                    case 5:

                        break;
                }
            }
        }
    }
}
