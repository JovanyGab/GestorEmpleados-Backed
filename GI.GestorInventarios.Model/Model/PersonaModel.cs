///CLASE DE LA TABLA GI_PERSONA
///DEVELOPER: JOVANY GABRIEL TALONIA ESTRADA
///DATE: 30 SEPTIEMBRE 2024
namespace GI.GestorInventarios.Model.Model
{
    public class PersonaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }

    }
}
