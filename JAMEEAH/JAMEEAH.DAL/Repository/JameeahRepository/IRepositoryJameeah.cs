using JAMEEAH.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMEEAH.DAL.Repository.JameeahRepository
{
    public interface IRepositoryJameeah
    {
        public _Jameeah  Create(_Jameeah jameeah);
        public _Jameeah Update(_Jameeah jameeah);
        public IEnumerable<_Jameeah> GetAll();  
        public _Jameeah Delete(int id);
        public _Jameeah GetById(int id);    
    }
}
