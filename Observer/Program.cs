using System;

/*
 * Задание № 5
 * Реализуйте коллекцию целых чисел, которая хранит в себе числа по возрастанию
 * (после добавления/удаления элемента происходит пересортировка). Предусмотреть
 * возможность обхода этой коллекции с использованием цикла for each. Добавьте
 * возможность подписываться на добавление/удаление элементов (паттерн Observer).
 * На примере простого консольного приложения продемонстрируйте возможности
 * коллекции.
 */


namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            Observer observer = new Observer(collection);
            Number num = new Number(213, 6546, 452, 3214);

            collection.RegisterObserver(observer);
            collection.Value = num;
            Console.WriteLine("Вывод коллекции");
            Console.WriteLine("---------");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            num.AddItem(654);
            Console.WriteLine("Добавлено число 654");
            Console.WriteLine("---------");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Удалено число по индексу 2");
            num.RemoveItem(2);
            Console.WriteLine("---------");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Отписываемся");
            collection.RemoveObserver(observer);
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
