using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Interfaces;

namespace Test.Models
{
    public class AppointmentEntity:IEntity
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public PatientEntity Patient { get; set; }
        public int PatientId { get; set; }
        public int DoctorEntityId { get; set; }
        public DoctorEntity Doctor { get; set; }
        public string Comment { get; set; }
    }
}