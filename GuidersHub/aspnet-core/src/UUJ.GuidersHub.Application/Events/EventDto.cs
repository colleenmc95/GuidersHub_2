using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUJ.GuidersHub.Events
{
    [AutoMapFrom(typeof(Event))]
    public class EventDto : EntityDto 
    {
        [Required]
        public String Name { get; set; }

        public DateTime CreationTime { get; set; }

        [Required]
        public DateTime EventTime { get; set; }

        [Required]
        public String Location { get; set; }

        public String Description { get; set; }
    }
}
