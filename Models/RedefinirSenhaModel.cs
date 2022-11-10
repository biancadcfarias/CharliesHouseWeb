﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharliesHouseWeb.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Digite o login do usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite a e-mail do usuário")]
        public string Email { get; set; }
    }
}
