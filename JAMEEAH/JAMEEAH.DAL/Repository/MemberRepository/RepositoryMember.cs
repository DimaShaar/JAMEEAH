using Jameeah.Domain.Data;
using JAMEEAH.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMEEAH.DAL.Repository.MemberRepository
{
    public class RepositoryMember : IRepositoryMember
    {
        private readonly ApplicationDBContext _dbContext;
        public RepositoryMember(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Member Create(Member member)
        {
            _dbContext.Members.Add(member);
            return member;
        }

        public Member Delete(int id)
        {
            var member = _dbContext.Members.SingleOrDefault(x => x.Id == id);
            if (member != null)
            {
                _dbContext.Members.Remove(member);
            }
            return member;
        }

        public IEnumerable<Member> GetAll()
        {
            return _dbContext.Members;
        }

        public Member GetById(int id)
        {
            return _dbContext.Members.FirstOrDefault(x => x.Id == id);
        }

        public Member Update(Member memberChange)
        {
            var member = _dbContext.Members.Attach(memberChange);
            member.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();
            return memberChange;

        }
    }
}
