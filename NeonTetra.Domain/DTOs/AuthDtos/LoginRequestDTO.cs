﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonTetra.Domain.DTOs.AuthDtos
{
    public class LoginRequestDTO
    {
        [Required(ErrorMessage = "Username cannot be blank")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password cannot be blank")]
        public string Password { get; set; }
    }
}
