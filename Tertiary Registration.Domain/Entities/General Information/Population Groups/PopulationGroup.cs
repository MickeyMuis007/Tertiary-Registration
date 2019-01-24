using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tertiary_Registration.Domain.Entities.GeneralInformation.PopulationGroups
{
    public class PopulationGroup : BaseEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
