using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tertiary_Registration.Domain.Entities.Courses;

namespace Tertiary_Registration.Domain.Entities.Qualifications
{
    public class Qualification : BaseEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<Course> Courses { get; set; }
    }
}
