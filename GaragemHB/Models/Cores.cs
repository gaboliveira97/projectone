using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GaragemHB.Models
{
    public class Cores
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }

    }
}