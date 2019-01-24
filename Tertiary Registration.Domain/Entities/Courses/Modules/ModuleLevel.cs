using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tertiary_Registration.Domain.Entities.Courses.Modules
{
    public class ModuleLevel : BaseEntity
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }

        public IEnumerable<Module> Modules { get; set; }
    }
}
