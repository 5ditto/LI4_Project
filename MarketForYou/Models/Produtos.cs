using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;

namespace MarketForYou.Models
{
    public class Produtos
    {
        [Key]
        public int produtoID { get; set; }
        public string nomeProd { get; set; }
        public string categoriaProd { get; set; }
        public string descricaoProd { get; set; }
        public int empresaID { get; set; }
        public int feiraID { get; set; }

        public Produtos() { }
        public Produtos(int produto, string nomeP, string categoriaP, string descricaoP, int empID, int fID)
        {
            this.produtoID = produto;
            this.nomeProd = nomeP;
            this.categoriaProd = categoriaP;
            this.descricaoProd = descricaoP;
            this.empresaID = empID;
            this.feiraID = fID;
        }
    }
}
