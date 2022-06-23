﻿using GaragemHB.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GaragemHB.Models
{
    public class Usuario : UserControls
    {
        [Key]
        
        public int Id { get; set; }

        [CustomValidFields(ValidFields.ValidaEmail)]
        public string Email { get; set; }
        public string Nome { get; set; }
        public bool ResideFora { get; set; } = false;
        public bool Carona { get; set; } = false;
        public bool PCD { get; set; } = false;
        public bool Noturno { get; set; } = false;
        public bool UsuGestor { get; set; } = false;

    }
}