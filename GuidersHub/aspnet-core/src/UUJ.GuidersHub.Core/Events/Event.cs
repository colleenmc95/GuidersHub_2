using Abp.Domain.Entities;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUJ.GuidersHub.Events
{
   [Table("Event")]
   public class Event : Entity
    {
        [Required]
        public String Name { get; set; }

        public DateTime CreationTime { get; set; }

        [Required]
        public DateTime EventTime { get; set; }

        [Required]
        public String Location { get; set; }

        public String Description { get; set; }

        public Event()
        {
            CreationTime = Clock.Now; 
        }

    }



}
