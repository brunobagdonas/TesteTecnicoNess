using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TesteTecnicoWebCoreJogador.Models
{
    [Table("Jogador")]
    public class Jogador
    {
        [Key]
        public int IdJogador { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Idade { get; set; }
        [Required]
        public int NumeroCamisa { get; set; }
        [Required]
        public int GolsMarcados { get; set; }
    }
}