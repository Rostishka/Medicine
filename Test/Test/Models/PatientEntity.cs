using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Interfaces;

namespace Test.Models
{
    public class PatientEntity :Person
    {

        public virtual List<AppointmentEntity> Apointments { get; set; } = new List<AppointmentEntity>();
        public virtual List<ReviewEntity> Reviews { get; set; } = new List<ReviewEntity>();
    }
}