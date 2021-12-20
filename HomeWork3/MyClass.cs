using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    /// <summary>
    /// Класс, реализующий однонаправленный одномерный список
    /// </summary>
    class MyList<MyType>
    {
        /// <summary>
        /// Реализация Элемента списка
        /// </summary>
        class MyListItem
        {
            public MyType Value;
            public MyListItem Next;
        }
        /// <summary>
        /// Первый элемент списка
        /// </summary>
        MyListItem head = null;

        /// <summary>
        /// Первоначальная длина списка
        /// </summary>
        private int length = 0;

        /// <summary>
        /// Реализация длины списка
        /// </summary>
        public int Length
        {
            get
            {
                return length;
            }
        }

        /// <summary>
        /// Метод, реализующий добавление элемента в список
        /// </summary>
        public void Add(MyType value)
        {
            // Увеличиваем длину списка
            length++;

            // Если первый элемент списка отсутствует, то создаем новый элемент и присваиваем ему значение
            if (head == null)
            {
                head = new MyListItem() { Value = value };
                return;
            }
            MyListItem current = head;
            // Пока следующий элемент списка не определен, сдвигаем текущий элемент вперед и присваиваем ему новое значение
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new MyListItem() { Value = value };
        }

        /// <summary>
        /// Метод, реализующий удаление элемента из списка по индексу
        /// </summary>
        public void RemoveAt(int index)
        {
            if (index >= 0 & index < length & head != null)
            {
                // Уменьшаем длину списка
                length--;

                // Если индекс равен нулю, то список остается без изменений
                if (index == 0)
                {
                    head = head.Next;
                }
                // Иначе перебираем список до нужного элемента
                // current1 присваивается значение нужного элемента
                // current2 присваивается значение следующего элемента (current1.Next)
                // current2.Next перешагивает еще на элемент вперед
                // current1 присваивается значение current2 
                // Итог: искомый элемент удаляется из последовательности            
                else
                {
                    MyListItem current1 = head;
                    for (int i = 0; i < index - 1; i++)
                    {
                        current1 = current1.Next;
                    }
                    MyListItem current2 = current1.Next;
                    current2 = current2.Next;
                    current1.Next = current2;
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс удаляемого элемента за пределами списка");
            }
        }

        /// <summary>
        /// Индексатор
        /// </summary>
        public MyType this[int index]
        {
            get
            {
                MyListItem current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return (current.Value);
            }
            set
            {
                MyListItem current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                current.Value = value;
            }
        }
    }
}
