using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System__Practice_
{
    public class MemberManager
    {
        private readonly List<Member> _members = new();

        public void AddMember(Member member)
        {
            _members.Add(member);
        }

        public void RemoveMember(Member member)
        {
            _members.Remove(member);
        }
        
        public bool FindMember(int id)
        {
            return _members.Any( m => m.Id == id);
        }

        public List<Member> GetMember()
        {
            return _members;
        }
    }
}
