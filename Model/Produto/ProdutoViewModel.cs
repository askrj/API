using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Produto
{
    [Table("TB_PRODUTO")]
    public class ProdutoViewModel
    {
        [Column("PROD_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Column("PROD_NOME")]
        [Display(Name = "Nome")]
        [MaxLength(150)]
        public string Nome { get; set; }
    }
}
