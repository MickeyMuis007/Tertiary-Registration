using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Addresses;

namespace Tertiary_Registration.Domain.Entities.Applicants
{
    public class ApplicantAddress : BaseEntity
    {
        public int Id { get; set; }
        public int ApplicantPersonalInfoId { get; set; }
        public int AddressTypeId { get; set; }
        public string Street { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }

        /* One to Many Relations */
        public ApplicantPersonalInfo ApplicantPersonalInfo { get; set; }
        public AddressType AddressType { get; set; }
    }
}
