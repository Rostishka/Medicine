﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Test.Interfaces;

namespace Test.Models
{
    public class ReviewEntity : IEntity
    {
        public ReviewEntity()
        {
        }

        public int Id { get; set; }
        public string Advantage { get; set; }
        public string Disadvantage { get; set; }
        public string Comment { get; set; }
        [Required]
        public string PatientEmail { get; set; }
        public string PatientEntityId { get; set; }
        public PatientEntity Patient { get; set; }
    }
}