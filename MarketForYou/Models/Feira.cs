namespace MarketForYou.Models
{
    public class Feira
    {
        public int feiraID { get; set; }
        public string name { get; set;}
        public DateTime date { get; set;}
        public string location { get; set;}
        public string category { get; set;}

        public Feira() { }

        public Feira(int fID, string nome, DateTime data, string localizacao, string categoria)
        {
            this.feiraID = fID;
            this.name = nome;
            this.date = data;
            this.location = localizacao;
            this.category = categoria;
        }   
    }
}
