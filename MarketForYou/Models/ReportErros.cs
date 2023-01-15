using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;


namespace MarketForYou.Models
{
    public class ReportErros
    {
        [Key]
        public int reportId { get; set; }
        public string anexo { get; set; }
        public string descricaoErro { get; set; }
        public string usernameCliente { get; set; }
        public ReportErros() { }

        public ReportErros(int repID, string anexoRE, string descricaoRE, string usernameCli)
        {
            this.reportId = repID;
            this.anexo = anexoRE;
            this.descricaoErro = descricaoRE;
            this.usernameCliente = usernameCli;
        }
    }
}
