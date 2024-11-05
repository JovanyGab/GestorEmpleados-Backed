namespace GI.GestorInventarios.Model.Model
{
    public class ProductoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }
        public string Color { get; set; }
        public int Stock { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
    }
}
