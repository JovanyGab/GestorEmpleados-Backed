///IProducto
///DEVELOPER: JOVANY GABRIEL TALONIA ESTRADA
///DATE: 7 DE OCTUBRE 2024


namespace GI.GestorInventarios.Model.Interfaces
{
    public interface IProducto
    {
        /// <summary>
        /// Este metodo permite agregar un Producto
        /// </summary>
        /// <returns></returns>
        Task<RespuestaBD> AgregarProducto();

        /// <summary>
        /// Este metodo permite actualizar un producto
        /// </summary>
        /// <returns></returns>
        Task<RespuestaBD> ActualizarProducto();

        /// <summary>
        /// Este metodo permite eliminar un producto
        /// </summary>
        /// <returns></returns>
        Task<RespuestaBD> EliminarProducto();

        /// <summary>
        /// Este metodo permite traer la lista de todas los productos
        /// </summary>
        /// <returns></returns>
        Task<List<ProductoModel>> ConsultarProducto(ParametrosEntrada param);


    }
}