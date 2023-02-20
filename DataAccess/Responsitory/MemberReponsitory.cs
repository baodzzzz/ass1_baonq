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
using System.Windows;
using Member = BusinessObject.Models.Member;


namespace DataAccess.Responsitory
{
    public class MemberReponsitory : IMemberRepository
    {
        public ASS1_DBContext db = new ASS1_DBContext();
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

        public void InsertMember(Member member)
        {
            db.Add<Member>(member);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Add successfully!");
            }
        }

        public bool Login(string email, string password)
        {
            if (email != null || password != null)
            {
                Member member = db.Members.FirstOrDefault(m => m.Email == email && m.Password == password);
                if (member == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public void UpdateMember(AutoMapper.Execution.Member member)
        {
            throw new NotImplementedException();
        }
    }
}
