using System.ComponentModel.DataAnnotations;

namespace PROGRESO_UNO_QUISPE_RONNY.Models
{
    public class Reservacs
    {
        


     
            [Key]
            public int ReservaId { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime FechaEntrada { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime FechaSalida { get; set; }

            [Required]
            [Range(0, 10000)]
            public decimal ValorPagar { get; set; }

            // Relación con cliente
            public int ClienteId { get; set; }
            
        }
    }







}
}
