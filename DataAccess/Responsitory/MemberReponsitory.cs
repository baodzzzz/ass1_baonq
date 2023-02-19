using AutoMapper;
using AutoMapper.Execution;
using BusinessObject;
using BusinessObject.Models;
using DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Member = BusinessObject.Models.Member;


namespace DataAccess.Responsitory
{
    public class MemberReponsitory : IMemberRepository
    {
        public void DeleteMember(AutoMapper.Execution.Member member)
        {
            throw new NotImplementedException();
        }

        public AutoMapper.Execution.Member GetMemberId(int memberId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AutoMapper.Execution.Member> GetMembers()
        {
            throw new NotImplementedException();
        }

        public void InsertMember(AutoMapper.Execution.Member member)
        {
            throw new NotImplementedException();
        }

        public bool Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void UpdateMember(AutoMapper.Execution.Member member)
        {
            throw new NotImplementedException();
        }
    }
}
