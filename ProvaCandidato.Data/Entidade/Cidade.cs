using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ProvaCandidato.Data.Entidade
{
    [Table("Cidade")]
    public class Cidade: IEntidade
    {
        [Key]
        [Column("codigo")]
        public int Codigo { get; set; }

        [Column("nome")]
        [MinLength(3)]
        [MaxLength(50)]
        [StringLength(50)]
        [Required]
        public string Nome { get; set; }
    }
}
