using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace SafetySquid._data._entities
{
    public class TicketRecieved
    {
        [Key]
        public int TicketRecievedId { get; set; }

        public DateTime DateRecieved { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Ticket Ticket { get; set; }

        private bool _valid;

        public bool Valid
        {
            get { return _valid; }
            set
            {
                _valid = DateRecieved + Ticket.ValidityLength < DateTime.Now;
            }
        }
    }
}
