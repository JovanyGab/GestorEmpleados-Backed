///IPERSONAINTERFACE 
///DEVELOPER: JOAVNY GABRIEL TALONIA ESTRADA
///DATE: 3 DE OCTUBRE 2024


namespace GI.GestorInventarios.Model.Interfaces
{
    public interface IPersonaInterface
    {
        /// <summary>
        /// Este metodo permite agregar un usuario
        /// </summary>
        /// <returns></returns>
        Task<RespuestaBD> AgregarPersona();

        /// <summary>
        /// Este metodo permite actualizar un usuario
        /// </summary>
        /// <returns></returns>
        Task<RespuestaBD> ActualizarPersona();

        /// <summary>
        /// Este metodo permite eliminar un usuario
        /// </summary>
        /// <returns></returns>
        Task<RespuestaBD> EliminarPersona();

        /// <summary>
        /// Este metodo permite traer la lista de todas las personas
        /// </summary>
        /// <returns></returns>
        Task<List <PersonaModel>> ConsultarPersona(ParametrosEntrada param);


    }
}