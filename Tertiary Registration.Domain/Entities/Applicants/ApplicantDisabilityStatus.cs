using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Disabilities;

namespace Tertiary_Registration.Domain.Entities.Applicants
{
    public class ApplicantDisabilityStatus : BaseEntity
    {
        public int Id { get; set; }

        /*
         * Note:
         * - The disablility is either other or specified type.
         * - The Unique constraint should be ApplicantId, DisabilityTypeId and OtherDisability
         *      - The all can't be the same.
         */
        public int ApplicantPersonalInfoId { get; set; }
        public int DisabilityTypeId { get; set; }
        public string OtherDisability { get; set; }        

        public ApplicantPersonalInfo ApplicantPersonalInfo { get; set; }
        public DisabilityType DisabilityType { get; set; }
    }
}
