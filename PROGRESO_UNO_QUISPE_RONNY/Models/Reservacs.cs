using System.ComponentModel.DataAnnotations;

namespace PROGRESO_UNO_QUISPE_RONNY.Models
{
    public class Reservacs
    {
        [Key]
        public int Id_Reserva { get; set }
        public string Identidicacion { get; set }

        public string Nombre
    }
}
