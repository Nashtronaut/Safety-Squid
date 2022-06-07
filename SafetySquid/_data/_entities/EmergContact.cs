using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace SafetySquid._data
{
    public class EmergContact
    {
        [Key]
        public int EmergContactId { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        [StringLength(10)]
        public string Cell { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
