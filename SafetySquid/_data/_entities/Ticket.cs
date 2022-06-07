using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace SafetySquid._data
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public TimeSpan ValidityLength { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
