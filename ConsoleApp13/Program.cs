using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        //В одномерном массиве из 8 целых чисел с явной инициализацией обнулить значения трех элементов, начиная с индекса, равного 1.
        //        static void Main(string[] args)
        //        {
        //            int[] array = { 5, 3, 7, 9, 2, 4, 6, 8 };


        //            for (int i = 1; i < 4; i++)
        //            {
        //                array[i] = 0;
        //            }


        //            Console.WriteLine("Массив после обнуления элементов:");
        //            foreach (int element in array)
        //            {
        //                Console.Write(element + " ");
        //            }

        //            Console.ReadLine();
        //        }
        //    }
        //}
        // Задача2. Изменить размер одномерного массива.
        //        static void Main(string[] args)
        //        {
        //            int[] array = { 1, 2, 3, 4, 5 };

        //            Console.WriteLine("Исходный массив:");
        //            foreach (int element in array)
        //            {
        //                Console.Write(element + " ");
        //            }

        //            Array.Resize(ref array, 8);

        //            array[5] = 6;
        //            array[6] = 7;
        //            array[7] = 8;

        //            Console.WriteLine("\nМассив после изменения размера:");
        //            foreach (int element in array)
        //            {
        //                Console.Write(element + " ");
        //            }

        //            Console.ReadLine();
        //        }
        //    }
        //}
        //Задача 3. Найти индекс первого отрицательного элемента одномерного массива, заполненного случайным образом в диапазоне от -5 до 5.
//        static void Main(string[] args)
//        {
//            Random rand = new Random();
//            int[] array = new int[10];

//            for (int i = 0; i < array.Length; i++)
//            {
//                array[i] = rand.Next(-5, 6);
//            }

//            Console.WriteLine("Массив:");
//            foreach (int element in array)
//            {
//                Console.Write(element + " ");
//            }

//            int index = -1;
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] < 0)
//                {
//                    index = i;
//                    break;
//                }
//            }

//            if (index != -1)
//            {
//                Console.WriteLine($"\nИндекс первого отрицательного элемента: {index}");
//            }
//            else
//            {
//                Console.WriteLine("\nОтрицательных элементов в массиве нет.");
//            }

//            Console.ReadLine();
//        }
//    }
//}