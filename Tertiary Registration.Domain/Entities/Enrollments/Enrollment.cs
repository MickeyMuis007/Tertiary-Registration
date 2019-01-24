using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tertiary_Registration.Domain.Entities.Applicants;
using Tertiary_Registration.Domain.Entities.Courses;

namespace Tertiary_Registration.Domain.Entities.Enrollments
{
    public class Enrollment : BaseEntity
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int CourseId { get; set; }

        public Applicant Applicant { get; set; }
        public Course Course { get; set; }
    }
}
