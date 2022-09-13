﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class PerformanceHistory
    {
        [Key]
        public int ID { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }
    }
}
