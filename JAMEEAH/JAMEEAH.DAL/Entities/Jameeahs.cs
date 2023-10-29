using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMEEAH.DAL.Entities
{
    public class Jameeahs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NumberOfMember { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string TotalOfPayment { get; set; }
        public string InstallmentsCount { get; set; }

        public virtual List<Members> Members { get; set; }
    }
}
