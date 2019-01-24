using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Genders;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Titles;

namespace Tertiary_Registration.Domain.Entities.Applicants
{
    public class ApplicantPersonalInfo : BaseEntity
    {
        public int ApplicantId { get; set; }
        public string IdentityNo { get; set; }
        public string Intial { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MaidenName { get; set; }
        public int GenderId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TitleId { get; set; }

        /* One to One Relations */
        public Applicant Applicant { get; set; }
        public ApplicantNationality ApplicantNationality { get; set; }                  // The reason for this is for solving the other issue
        public ApplicantPopulationGroup ApplicationPopulationGroup { get; set; }        // The reason for this is for solving the other issue

        /* One to Many Relations */
        public Gender Gender { get; set; }
        public Title Title { get; set; }

        public IEnumerable<ApplicantLanguage> ApplicantLanguage { get; set; }
        public IEnumerable<ApplicantDisabilityStatus> ApplicantDisabilityStatuses { get; set; }
        public IEnumerable<ApplicantAddress> ApplicantAddresses { get; set; }
        public IEnumerable<ApplicantContact> ApplicantContacts { get; set; }
    }
}
