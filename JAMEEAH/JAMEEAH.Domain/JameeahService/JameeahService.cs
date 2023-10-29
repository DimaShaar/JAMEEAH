using JAMEEAH.DAL.Entities;
using JAMEEAH.DAL.Repository.JameeahRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMEEAH.Domain.JameeahService
{
    public class JameeahService:IJameeahService
    {
        private readonly IRepositoryJameeah _repositoryJameeah;
        public JameeahService(IRepositoryJameeah repositoryJameeah)
        {
            _repositoryJameeah = repositoryJameeah;
        }

        public _Jameeah Create(_Jameeah jameeah)
        {
            return _repositoryJameeah.Create(jameeah);
        }

        public _Jameeah Delete(int id)
        {
            return _repositoryJameeah.Delete(id);  
        }

        public IEnumerable<_Jameeah> GetAll()
        {
            return _repositoryJameeah.GetAll();
        }

        public _Jameeah GetById(int id)
        {
            return _repositoryJameeah.GetById(id);
        }

        public _Jameeah Update(_Jameeah jameeah)
        {
           return _repositoryJameeah.Update(jameeah); 
        }
    }
}
