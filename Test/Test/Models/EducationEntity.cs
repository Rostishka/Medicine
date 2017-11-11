﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Interfaces;

namespace Test.Models
{
    public class EducationEntity : IEntity
    {
        public int Id { get; set; }
        public string Place { get; set; }
        public string Speciality { get; set; }
        public int GraduateYear { get; set; }
    }
}