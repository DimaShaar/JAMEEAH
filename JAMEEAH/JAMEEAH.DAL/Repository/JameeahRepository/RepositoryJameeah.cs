using Jameeah.Domain.Data;
using JAMEEAH.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMEEAH.DAL.Repository.JameeahRepository
{
    public class RepositoryJameeah : IRepositoryJameeah
    {
        private readonly ApplicationDBContext _dbContext;
        public RepositoryJameeah(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext; 
        }
        public _Jameeah Create(_Jameeah jameeah)
        {
            _dbContext.Jameeah.Add(jameeah);
            return jameeah;
        }

        public _Jameeah Delete(int id)
        {
            var jameeah = _dbContext.Jameeah.SingleOrDefault(x=> x.Id == id); 
            if (jameeah != null)
            {
                _dbContext.Jameeah.Remove(jameeah);
            }
            return jameeah; 
        }

        public IEnumerable<_Jameeah> GetAll()
        {
            return _dbContext.Jameeah;
        }

        public _Jameeah GetById(int id)
        {
            return _dbContext.Jameeah.FirstOrDefault(x => x.Id == id);
        }

        public _Jameeah Update(_Jameeah jameeah)
        {
            var Jameeah = _dbContext.Jameeah.Attach(jameeah);
            Jameeah.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();   
            return jameeah; 

        }
    }
}
