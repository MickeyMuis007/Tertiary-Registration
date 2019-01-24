using System.Collections.Generic;
using Tertiary_Registration.Domain.Entities.Facilties;
using Tertiary_Registration.Domain.Entities.Qualifications;

namespace Tertiary_Registration.Domain.Entities.Courses
{
    public class Course : BaseEntity
    {
        public int Id { get; set; }
        public int FaciltyId { get; set; }
        public int QualificationId { get; set; }
        public string CourseCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Facilty Facilty { get; set; }
        public Qualification Qualification { get; set; }
 
        public IEnumerable<CourseModule> CourseModules { get; set; }
    }
}
