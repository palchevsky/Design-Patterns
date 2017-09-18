using System;

/*
 * Задание № 6
 * Реализуйте простую модель чата/мессенджера с возможностью личной переписки,
 * хранения а также объединения в группы участников (паттерн Mediator).
 */

namespace Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatic = new ChatGroup("Atlant");
            var memb1 = new Member(chatic, "ХХЛ15");
            var memb2 = new Member(chatic, "CharoN");
            var memb3 = new Member(chatic, "Бубен");
            var memb4 = new Member(chatic, "Друган");
            Console.WriteLine("------Сообщение в чат------");
            memb1.SendMessage("Не забываем выключать освещение при уходе с работы ");
            Console.WriteLine("------Сообщение в личку------");
            memb1.SendMessageToMember("Сообщение в личку", memb2);
        }
    }
}
