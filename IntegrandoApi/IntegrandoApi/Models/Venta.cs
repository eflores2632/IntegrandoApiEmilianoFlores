namespace IntegrandoApi.Models
{

    public class Venta
    {
        private int id;
        private int idUsuario;

        public Venta(string comentarios, int idUsuario)
        {
            this.Comentarios = comentarios;
            this.idUsuario = idUsuario;
        }
        [JsonConstructorAttribute]
        public Venta(int id, string comentarios, int idUsuario)
        {
            this.id = id;
            Comentarios = comentarios;
        }
        public int Id { get => id; set => id = value; }
        public string Comentarios { get; set; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}