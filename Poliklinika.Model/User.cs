﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Poliklinika.Model
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
