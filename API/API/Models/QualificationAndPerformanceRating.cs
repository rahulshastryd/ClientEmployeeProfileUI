using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class QualificationAndPerformanceRating
    {
        [Key]
        public int ID { get; set; }
        public string DegreeLevel { get; set; }
        public string Qualification { get; set; }
        public string University { get; set; }
        public string CGPA { get; set; }
    }
}
