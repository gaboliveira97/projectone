using EnumsNET;
using GaragemHB.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GaragemHB.Models
{
    public class Locacao
    {
        [Key]
        public int Id { get; set; }

        [CustomValidFields(ValidFields.ValidaPlaca)]
        public string Placa { get; set; } = "XXX-0800";

        [ForeignKey("Modelo_FK")]
        public Modelo Modelo { get; set; }
        public int Modelo_FK { get; set; }

        [ForeignKey("Cores_FK")]
        public Cores Cores { get; set; }
        public int Cores_FK { get; set; }

        [ForeignKey("CadastroPeriodo_FK")]
        public RegistroPeriodo CadastroPeriodo { get; set; }
        public int CadastroPeriodo_FK { get; set; }

        [ForeignKey("Usuario_FK")]
        public Usuario Usuario { get; set; }
        public int Usuario_FK { get; set; }

        [ForeignKey("TermoDeUso_FK")]
        public TermoDeUso TermoDeUso { get; set; }
        public int TermoDeUso_FK { get; set; }


    }
}