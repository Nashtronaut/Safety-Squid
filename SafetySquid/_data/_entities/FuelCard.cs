using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace SafetySquid._data._entities
{
    public class FuelCard
    {
        [Key]
        public int FuelCardId { get; set; }

        [StringLength(30)]
        public string Brand { get; set; }

        public virtual Employee? Employee { get; set; }

    }
}
