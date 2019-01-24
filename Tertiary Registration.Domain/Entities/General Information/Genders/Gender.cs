using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tertiary_Registration.Domain.Entities.Applicants;

namespace Tertiary_Registration.Domain.Entities.GeneralInformation.Genders
{
    public class Gender : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        /* One to Many Relations */
        public IEnumerable<ApplicantPersonalInfo> ApplicantPersonalInfos { get; set; }
    }
}
