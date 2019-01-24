using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tertiary_Registration.Domain.Entities.Applicants
{
    public class ApplicantContact : BaseEntity
    {
        public int Id { get; set; }
        public int ApplicantPersonalInfoId { get; set; }
        public string HomeNo { get; set; }
        public string WorkNo { get; set; }
        public string CellNo { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        
        /* One to Many Relations */
        public ApplicantPersonalInfo ApplicantPersonalInfo { get; set; }
    }
}
