using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiUltimate.Models
{
    public class Cliente : UserControl
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string EstadoCivil { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}