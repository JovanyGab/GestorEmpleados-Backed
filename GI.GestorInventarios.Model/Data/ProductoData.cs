namespace GI.GestorInventarios.Model.Data
{
    internal class ProductoData : IProducto
    {
        public async Task<RespuestaBD> ActualizarProducto()
        {
            var respuesta = new RespuestaBD();
            respuesta.NumError = 1;
            respuesta.Mensaje = "El registro se actualizo correctamente";
            return respuesta;
        }

        public async Task<RespuestaBD> AgregarProducto()
        {
            var respuesta = new RespuestaBD();
            respuesta.NumError = 1;
            respuesta.Mensaje = "El registro se actualizo correctamente";
            return respuesta;
        }

        public async Task<List<ProductoModel>> ConsultarProducto(ParametrosEntrada param)
        
        {
            var lista = new List<ProductoModel>();

            lista.Add(new ProductoModel
            {
                Nombre = "Nito",
                Precio = 20.99,
                Categoria = "Pan",
                Color = "Verde",
                Stock = 20

               
            });

            return lista;
        }

        public async Task<RespuestaBD> EliminarProducto()
        {
            var respuesta = new RespuestaBD();
            respuesta.NumError = 1;
            respuesta.Mensaje = "El registro se actualizo correctamente";
            return respuesta;
        }
    }
}
