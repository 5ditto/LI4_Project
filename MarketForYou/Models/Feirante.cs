using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;

namespace MarketForYou.Models
{
    public class Feirante
    {
        [Key]
        public string usernameFei { get; set; }
        public string emailFei { get; set; }
        public string passwordFei { get; set; }
        public int numVisitasFei { get; set; }
        public int feiraID { get; set; }

        public Feirante() { }
        public Feirante (string usernameFe, string emailFe, string passwordFe, int numVisitasFe, int fID)
        {
            this.usernameFei = usernameFe;
            this.emailFei = emailFe;
            this.passwordFei = passwordFe;
            this.numVisitasFei = numVisitasFe;
            this.feiraID = fID;
        }
    }
}
