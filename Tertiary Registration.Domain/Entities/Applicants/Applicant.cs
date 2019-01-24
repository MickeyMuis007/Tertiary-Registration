using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tertiary_Registration.Domain.Entities.Enrollments;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Registrations;

namespace Tertiary_Registration.Domain.Entities.Applicants
{
    public class Applicant : BaseEntity
    {
        public int Id { get; set; }
        public string StudentNo { get; set; }
        public int RegistrationRegionId { get; set; }

        /* One to One Relations */
        public ApplicantPersonalInfo ApplicantPersonalInfo { get; set; }

        /* One to Many Relations */
        public RegistrationRegion RegistrationRegion { get; set; }

        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}
