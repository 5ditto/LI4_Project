using System.Drawing.Printing;

namespace MarketForYou.Models
{
    public class Feirante
    {
        public string usernameFei { get; set; }
        public string emailFei { get; set; }
        public string passwordFei { get; set; }
        public int feiraID { get; set; }

        public Feirante() { }
        public Feirante (string usernameF, string emailF, string passwordF, int fID)
        {
            this.usernameFei = usernameF;
            this.emailFei = emailF;
            this.passwordFei = passwordF;
            this.feiraID = fID;
        }
    }
}
