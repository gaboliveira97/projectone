using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GaragemHB.Models
{
    public class Modelo
    {
        [Key]
        public int Id { get; set; }
        public string CodigoModelo { get; set; }
        public string DescricaoModelo { get; set; }

        [ForeignKey("MarcaFK")]
        public Marca Marca { get; set; }
        public int MarcaFK { get; set; }
    }
}