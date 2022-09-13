using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CareerHistory
    {
        [Key]
        public int ID { get; set; }
        public string Job { get; set; }
        public string Grade { get; set; }
        public string Organisation { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string ReasonForChange { get; set; }

    }
}
