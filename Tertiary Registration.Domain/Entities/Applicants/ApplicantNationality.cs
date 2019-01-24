using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Nationalities;

namespace Tertiary_Registration.Domain.Entities.Applicants
{
    public class ApplicantNationality : BaseEntity
    {
        public int ApplicationPersonalInfoId { get; set; }
        public int NationalityId { get; set; }
        public string Other { get; set; }
        
        /* One to One Relations */
        public ApplicantPersonalInfo ApplicantPersonalInfo { get; set; }

        /* One to Many Relations */
        public Nationality Nationality { get; set; }
    }
}
