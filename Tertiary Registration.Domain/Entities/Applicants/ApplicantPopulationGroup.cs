using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tertiary_Registration.Domain.Entities.GeneralInformation.PopulationGroups;

namespace Tertiary_Registration.Domain.Entities.Applicants
{
    public class ApplicantPopulationGroup : BaseEntity
    {
        public int ApplicantPersonalInfoId { get; set; }
        public int PopulationGroupId { get; set; }
        public string Other { get; set; }

        public ApplicantPersonalInfo ApplicantPesonalInfo { get; set; }
        public PopulationGroup PopulationGroup { get; set; }
    }
}
