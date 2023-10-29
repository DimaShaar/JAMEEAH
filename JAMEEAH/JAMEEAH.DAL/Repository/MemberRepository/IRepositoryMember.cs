using JAMEEAH.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMEEAH.DAL.Repository.MemberRepository
{
    public interface IRepositoryMember
    {
        public Member Create(Member member);
        public Member Update(Member memberChange);
        public IEnumerable<Member> GetAll();
        public Member Delete(int id);
        public Member GetById(int id);
    }
}
