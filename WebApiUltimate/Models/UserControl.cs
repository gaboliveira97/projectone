using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiUltimate.Models
{
    public class UserControl
    {
        public bool Ativo { get; set; } = true;
        public int UsuCriacao { get; set; } = 0;
        public int UsuAlter { get; set; } = 0;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlter { get; set; } = DateTime.Now;
    }
}