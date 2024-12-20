﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class SignUpRequest
    {
        public string? Name { get; set; } = string.Empty;
        public string? EmailID { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public string? State { get; set; } = string.Empty;
        public string? Country { get; set; } = string.Empty;
        public string? PanNumber { get; set; } = string.Empty;
        public string? ContactNumber { get; set; } = string.Empty;
        public string? DateOfBirth { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
    }
}
