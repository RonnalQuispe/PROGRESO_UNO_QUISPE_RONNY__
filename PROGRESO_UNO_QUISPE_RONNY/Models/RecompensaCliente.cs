using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROGRESO_UNO_QUISPE_RONNY.Models
{
    public class RecompensaCliente
    {

        [Key]
        public int RecompensaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Required]
        public int PuntosAcumulados { get; set; }

        [Required]
        [StringLength(20)]
        public string TipoRecompensa
        {
            get
            {
                if (PuntosAcumulados < 500)
                    return " cliente silver ....    ;)";
                else
                    return "gold.....  ;)";
            }
        }

        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }
 






}
}
