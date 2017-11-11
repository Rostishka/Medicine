using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Test.Models;

namespace Test.Models
{
    public class MedContext:DbContext
    {
        public DbSet<DoctorEntity> Doctors{ get; set; }
        public DbSet<EducationEntity> Educations { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PatientEntity> Patients{ get; set; }
        public DbSet<ExperienceEntity> Experiences{ get; set; }
        public DbSet<ReviewEntity> Reviews { get; set; }
        public DbSet<AppointmentEntity> Appointments{ get; set; }

    }
}