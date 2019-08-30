using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GaragemHB.Enums;

namespace GaragemHB.Models
{
    public class Marca
    {
        public int Id { get; set; }
        public int CodigoMarca { get; set; }
        public string DescricaoMarca { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }
    }
}