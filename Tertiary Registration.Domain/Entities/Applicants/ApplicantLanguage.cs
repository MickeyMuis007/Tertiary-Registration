using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tertiary_Registration.Domain.Entities.GeneralInformation.Languages;

namespace Tertiary_Registration.Domain.Entities.Applicants
{
    public class ApplicantLanguage
    {
        public int Id { get; set; }

        /*
         * Note:
         * - The language is either OtherLanguage or specified LanguageId.
         * - The Unique constraint should be LanguageId, ApplicationPersonalInfoId and OtherLanguage
         *      - The all can't be the same.
         */
        public int ApplicationPersonalInfoId { get; set; }
        public int LanguageId { get; set; }
        public int LanguageTypeId { get; set; }
        public string OtherLanguage { get; set; }

        /* One to Many Relations */
        public Language Language { get; set; }
        public LanguageType LanguageType { get; set; }
        public ApplicantPersonalInfo ApplicantPersonalInfo { get; set; }

    }
}
