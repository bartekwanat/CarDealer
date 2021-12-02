using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public class Car
    {
        [Key]
        public int ID { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int Mileage { get; set; }
        public int Capacity { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Year of production")]
        public DateTime ProductionYear { get; set; }
       
        [Display(Name = "Horse Power")]
        public int HorsePower { get; set; }

        public int Price { get; set; }
        
     }
}
