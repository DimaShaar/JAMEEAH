using JAMEEAH.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMEEAH.Domain.MemberService
{
    public interface IMemberService
    {
        public Member GetById(int id);

        public IEnumerable<Member> GetAll();
        public Member Create(Member member);
        public Member Delete(int id);

        public Member Update(Member member);
    }
}
