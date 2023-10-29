using JAMEEAH.DAL.Entities;
using JAMEEAH.DAL.Repository.MemberRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMEEAH.Domain.MemberService
{
    public class MemberService:IMemberService
    {
        private readonly IRepositoryMember _repositoryMember; 
        
        public MemberService(IRepositoryMember repositoryMember)
        {
            _repositoryMember = repositoryMember;
        }

        public Member Create(Member member)
        {
            return _repositoryMember.Create(member);
        }

        public Member Delete(int id)
        {
            return _repositoryMember.Delete(id);
        }

        public IEnumerable<Member> GetAll()
        {
            return _repositoryMember.GetAll();
        }

        public Member GetById(int id)
        {
            return _repositoryMember.GetById(id);   
        }

        public Member Update(Member member)
        {
            return _repositoryMember.Update(member);
        }
    }
}
