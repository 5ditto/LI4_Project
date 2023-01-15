namespace MarketForYou.Models
{
    public class Feira
    {
        public int feiraID { get; set; }
        public string nomeFeira { get; set;}
        public DateTime dataFeira { get; set;}
        public string localizacaoFeira { get; set;}
        public string categoriaFeira { get; set;}
        public int numVisitasFeira { get; set;} 
        public Feira() { }

        public Feira(int fID, string nomeF, DateTime dataF, string localizacaoF, string categoriaF, int numVisitasF)
        {
            this.feiraID = fID;
            this.nomeFeira = nomeF;
            this.dataFeira = dataF;
            this.localizacaoFeira = localizacaoF;
            this.categoriaFeira = categoriaF;
            this.numVisitasFeira = numVisitasF;
        }
    }
}
