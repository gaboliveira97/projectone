using GaragemHB.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GaragemHB.Models
{
    public class Valor
    {
        [Key]
        public int Id { get; set; }
        public TipoVeiculo tipoveiculo {get; set;}
        public string valor { get; set; }

    }
}