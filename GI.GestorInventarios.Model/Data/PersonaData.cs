namespace GI.GestorInventarios.Model.Data
{
    public class PersonaData : IPersonaInterface
       
       
    {
        /// <summary>
        /// Permite actualizar una persona
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<RespuestaBD> ActualizarPersona()
        {
         var respuesta = new RespuestaBD();
            respuesta.NumError = 1;
            respuesta.Mensaje = "El registro se actualizo correctamente";
            return respuesta;
        }
        /// <summary>
        /// Permite agregar una persona
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<RespuestaBD> AgregarPersona()
        {
            var respuesta = new RespuestaBD();
            respuesta.NumError = 1;
            respuesta.Mensaje = "El registro se agrego correctamente";
            return respuesta;
        }
        /// <summary>
        /// Permite consultar una persona
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<List<PersonaModel>> ConsultarPersona(ParametrosEntrada param)
        {
            var lista = new List<PersonaModel>();

            lista.Add(new PersonaModel
            {
                Nombre = "Diego",
                ApellidoPaterno = "Barrera",
                ApellidoMaterno = "Garcia",
                Edad = 22

            });

            lista.Add(new PersonaModel
            {
                Nombre = "Dani",
                ApellidoPaterno = "Solares",
                ApellidoMaterno = "Cruz",
                Edad = 21

            });

            return lista;
        }
        /// <summary>
        /// Permite eliminar una persona
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<RespuestaBD> EliminarPersona()
        {
            var respuesta = new RespuestaBD();
            respuesta.NumError = 1;
            respuesta.Mensaje = "El registro se elimino correctamente";
            return respuesta;
        }
    }
}
