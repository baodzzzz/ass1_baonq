using AutoMapper.Execution;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IMemberRepository
    {
        bool Login(string email, string password);
        IEnumerable<Member> GetMembers();
        Member GetMemberId(int memberId);
        void InsertMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(Member member);
    }
}
