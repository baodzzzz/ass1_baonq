using AutoMapper;
using AutoMapper.Execution;
using BusinessObject;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Member = BusinessObject.Models.Member;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                }
                return instance;
            }
        }
        public IEnumerable<Member> GetMemberList()
        {
            List<Member> members;
            try
            {
                var dbContext = new ASS1_DBContext();
                members = dbContext.Members.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }
        public Member GetMemberById(int memberID)
        {
            Member member;
            try
            {
                var dbContext = new ASS1_DBContext();
                member = dbContext.Members.SingleOrDefault(member => member.MemberId == memberID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }
        public void AddNewMember(Member member)
        {
            try
            {
                Member _member = GetMemberById(member.MemberId);
                if (_member == null)
                {
                    var dbContext = new ASS1_DBContext();
                    dbContext.Members.Add(member);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("The member is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public void UpdateMember(Member member)
        {
            try
            {
                Member _member = GetMemberById(member.MemberId);
                if (_member != null)
                {
                    var dbContext = new ASS1_DBContext();
                    dbContext.Entry<Member>(member).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("The member does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoveMember(Member member)
        {
            try
            {
                Member _member = GetMemberById(member.MemberId);
                if (_member != null)
                {
                    var dbContext = new ASS1_DBContext();
                    dbContext.Members.Remove(member);
                    dbContext.SaveChanges();
                }

                else
                {
                    throw new Exception("The member does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } // end Remove
    }
}
