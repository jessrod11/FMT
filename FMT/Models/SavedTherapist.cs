using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMT.Models
{
    public class SavedTherapist
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TherapistId { get; set; }
    }
}
