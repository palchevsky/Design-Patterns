using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Задание № 2
 * Реализуйте с помощью паттерна Composite обход иерархии веб-страниц на сайте в виде
 * единого дерева. Структура сайта такова:
 * 1. Простые страницы с информацией.
 * 2. Разделы, содержащее некое описание, а также список вложенных простых страниц.
 * 3. Главная страница, содержащая список разделов.
 */


namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var section1 = new Section() { Header = "Нормативка", Info = "Нормативные документы" };
            section1.AddPage(new Page() { Header = "Указ", Info = "Указ Президента РБ" });
            section1.AddPage(new Page() { Header = "Декрет", Info = "Дектер Президента РБ" });
            section1.AddPage(new Page() { Header = "Закон", Info = "Закон РБ" });
            section1.AddPage(new Page() { Header = "Постановление", Info = "Постановление Правительства РБ" });

            var section2 = new Section() { Header = "Офисы", Info = "Офисы продаж" };
            section2.AddPage(new Page() { Header = "Минск", Info = "Минск, Беларусь" });
            section2.AddPage(new Page() { Header = "Киев", Info = "Киев, Украина" });
            section2.AddPage(new Page() { Header = "Таллинн", Info = "Эстония, Таллинн" });
            section2.AddPage(new Page() { Header = "Москва", Info = "Москва, Россия" });

            var mainPage = new Section() { Header = "Главная страница", Info = "Основная страница сайта" };
            mainPage.AddPage(section1);
            mainPage.AddPage(section2);
            mainPage.Print();
            Console.WriteLine();
            Console.WriteLine("Попытка найти Киев");
            var Kiev = mainPage.Find("Киев");
            Kiev.Print();
            Console.ReadKey();
        }
    }
}
