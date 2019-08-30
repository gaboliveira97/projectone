using GaragemHB.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GaragemHB.Models
{
    public class RegistroPeriodo
    {
        //UsuarioGestor
        [Key]
        public int Id { get; set; }

        [ForeignKey("Modelo_FK")]
        public Modelo Modelo { get; set; }
        public int Modelo_FK { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        [NotMapped]
        public bool Vigente => DateTime.Today <= DataFinal;

    }
}
