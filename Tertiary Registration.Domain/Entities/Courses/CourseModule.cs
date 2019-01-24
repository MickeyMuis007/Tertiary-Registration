using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tertiary_Registration.Domain.Entities.Courses.Modules;

namespace Tertiary_Registration.Domain.Entities.Courses
{
    public class CourseModule : BaseEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ModuleId { get; set; }
        
        public Course Course { get; set; }
        public Module Module { get; set; }
    }
}
