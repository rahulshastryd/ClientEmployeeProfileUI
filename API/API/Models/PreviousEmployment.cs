using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class PreviousEmployment
    {
        [Key]
        public int ID { get; set; }
        public string Entity { get; set; }
        public string Job { get; set; }
        public DateTime Start { get; set; }
        public DateTime Till { get; set; }
    }
}
