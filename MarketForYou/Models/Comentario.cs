namespace MarketForYou.Models
{
    public class Comentario
    {
        public int comentarioId { get; set; }
        public string descricaoComentario { get; set; }
        public string usernameCliente { get; set; }
        public string usernameFei { get; set; }
        public int feiraID { get; set; }
        
        public Comentario() { }
        
        public Comentario(int comenID, string descCom, string userCli, string userFei, int fID)
        {
            this.comentarioId = comenID;
            this.descricaoComentario = descCom;
            this.usernameCliente = userCli;
            this.usernameFei = userFei;
            this.feiraID = fID;
        }
    }
}
