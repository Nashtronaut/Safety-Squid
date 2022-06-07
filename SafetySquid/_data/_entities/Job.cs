using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace SafetySquid._data
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [StringLength(30)]
        public string Client { get; set; }

        public int ForemanId { get; set; }

        public int SafetyId { get; set; }

        public int? StraitForemanId { get; set; }

        public int? StraitSafetyId { get; set; }

        public int? QualityControlId {get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }

    }
}
