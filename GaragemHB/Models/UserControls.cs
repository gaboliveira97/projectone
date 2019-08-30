using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GaragemHB.Models
{
    public class UserControls
    {
        public bool Ativo { get; set; } = true;
        public int UsuAdd { get; set; } = 0;
        public int UsuAlter { get; set; } = 0;
        public DateTime DataAdd { get; set; } = DateTime.Now;
        public DateTime DataAlter { get; set; } = DateTime.Now;
    }
}