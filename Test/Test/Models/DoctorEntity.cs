using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Interfaces;

namespace Test.Models
{
    public class DoctorEntity:Person
    {
        public int Age { get; set; }
        public string Information { get; set; }
        public ICollection<AppointmentEntity> Appointments { get; set; }
        public List<string> Procedures { get; set; }
        public List<EducationEntity> Educations { get; set; }
        public ICollection<ExperienceEntity> Type { get; set; }
        public string Location { get; set; }
        public ExperienceEntity CurrentWorkPlace { get; set; }
    }
}