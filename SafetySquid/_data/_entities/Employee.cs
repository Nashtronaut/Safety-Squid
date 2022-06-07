using SafetySquid._data._entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace SafetySquid._data
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(30)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Street { get; set; }

        [StringLength(20)]
        public string Province { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(7)]
        public string PostalCode { get; set; }

        [StringLength(9)]
        public string? Phone { get; set; }

        [StringLength(9)]
        public string? Cell { get; set; }

        public double Wage { get; set; }

        public bool LivingAllowance { get; set; }

        public bool TruckPayment { get; set; }

        [StringLength(30)]
        public string JobTitle { get; set; }

        public virtual ICollection<Ticket>? Tickets { get; set; }

        public int? JobId { get; set; }
        public virtual Job? Job { get; set; }

        public int EmergContactId { get; set; }
        public virtual EmergContact EmergContact { get; set; }

        public int? UnitId { get; set; }
        public virtual Unit? Unit { get; set; }

        public int? FuelCardId { get; set; }
        public virtual FuelCard? FuelCard{ get; set; }

    }
}
