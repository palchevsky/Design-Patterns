using System;

namespace Chat
{
    class Member
    {
        private readonly ChatGroup _chat;
        public string Name { get; set; }
        public Member(ChatGroup chat, string name)
        {
            _chat = chat;
            Name = name;
            _chat.AddMember(this);
        }

        public void GetMessage(string message, Member from)
        {
            if (Name != from.Name)
            {
                Console.WriteLine("{0} получил от {1} сообщение: {2}",
                    this.Name, from.Name, message);
            }
        }

        public void GetMessageByMember(string message, Member from, Member to)
        {
            if (Name != from.Name)
            {
                Console.WriteLine("{0} получил от {1} личное сообщение: {2}",
                    to.Name, from.Name, message);
            }
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("{0} отправил сообщение в чат: {1}", Name, message);
            _chat.Send(message, this);
        }

        public void SendMessageToMember(string message, Member member)
        {

            Console.WriteLine("{0} отправил {1} личное сообщение: {2}", Name, member.Name, message);
            _chat.SendToMember(message, this, member);
        }

    }
}
