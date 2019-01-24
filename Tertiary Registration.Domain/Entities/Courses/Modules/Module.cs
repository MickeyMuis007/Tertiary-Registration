using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tertiary_Registration.Domain.Entities.Courses.Modules
{
    public class Module : BaseEntity
    {
        public int Id { get; set; }
        public int ModuleLevelId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Compulsory { get; set; }

        public ModuleLevel ModuleLevel { get; set; }

        public IEnumerable<CourseModule> CourseModules { get; set; }
    }
}
