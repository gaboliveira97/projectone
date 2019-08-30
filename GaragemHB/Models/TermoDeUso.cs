using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GaragemHB.Models
{
    public class TermoDeUso 
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Atual { get; set; } 
    }
}