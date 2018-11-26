using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int id {get; set; }
        [Required]
        public string Name { get; set; }
        [NotMapped]
        public List<CelestialObject> Satalites { get; set; }
        public TimeSpan OrbitalPeriod {get; set; }
        
    }
}