using System;

namespace HomeWork3
{
    /// <summary>
    /// Работа программы
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Список строковых значений: ");
            try
            {
                // Создаем новый экземпляр списка MyList и задаем, что он принимает строковые значения
                MyList<string> list1 = new MyList<string>();

                // Заполняем его случайными значениями (конвертируем числа в строковый тип данных)
                for (int i = 0; i < 20; i++)
                {
                    list1.Add(random.Next(-10, 10).ToString());
                }

                // Выводим исходный список элементов
                for (int i = 0; i < list1.Length; i++)
                {
                    Console.Write(list1[i] + " ");
                }

                Console.WriteLine();

                // Удаляем случайный элемент списка (индекс может выходить за диапазон)
                list1.RemoveAt(random.Next(-30, 30));

                // Выводим измененный список
                for (int i = 0; i < list1.Length; i++)
                {
                    Console.Write(list1[i] + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n");


            Console.WriteLine("Список целочисленных значений значений: ");
            try
            {
                // Создаем новый экземпляр списка MyList и задаем, что он принимает целочисленные значения
                MyList<int> list2 = new MyList<int>();

                // Заполняем его случайными значениями
                for (int i = 0; i < 20; i++)
                {
                    list2.Add(random.Next(-10, 10));
                }

                // Выводим исходный список элементов
                for (int i = 0; i < list2.Length; i++)
                {
                    Console.Write(list2[i] + " ");
                }

                Console.WriteLine();

                // Удаляем случайный элемент списка (индекс может выходить за диапазон)
                list2.RemoveAt(random.Next(-30, 30));

                // Выводим измененный список
                for (int i = 0; i < list2.Length; i++)
                {
                    Console.Write(list2[i] + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }

}
