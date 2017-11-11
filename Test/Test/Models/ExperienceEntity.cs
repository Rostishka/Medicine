using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Interfaces;

namespace Test.Models
{
    public class ExperienceEntity : IEntity
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string Place { get; set; }

        public string Description { get; set; }
    }
}