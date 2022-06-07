using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace SafetySquid._data._entities
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }

        [StringLength(30)]
        public string Make { get; set; }

        [StringLength(30)]
        public string Model { get; set; }

        [StringLength(8)]
        public string LicensePlate { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
