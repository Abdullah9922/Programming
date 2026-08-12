using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System___Modified__
{
    public class MemberManager
    {
        private readonly List<Member> _members = new();

        public void RegisterMember(Member member)
        {
            _members.Add(member);
        }

        public Member? FindMember(int id)
        {
            return _members.FirstOrDefault(m => m.Id == id);
        }

        public List<Member> GetAllMembers()
        {
            return _members;
        }
    }
}
