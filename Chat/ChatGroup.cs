using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class ChatGroup
    {
        private readonly IList<Member> _members = new List<Member>();

        public void AddMember(Member member)
        {
            Console.WriteLine("В чат вошёл {0}", member.Name);
            _members.Add(member);
        }

        public void Send(string message, Member from)
        {
            foreach (var participant in _members)
            {
                participant.GetMessage(message, from);
            }
        }

        public void SendToMember(string message, Member from, Member to)
        {
           to.GetMessageByMember(message, from,to);
        }


        public ChatGroup(string name)
        {
            Console.WriteLine("Добро пожаловать в чат {0}", name);
        }
    }
}
