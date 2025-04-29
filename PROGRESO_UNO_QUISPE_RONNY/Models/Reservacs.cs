using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace PROGRESO_UNO_QUISPE_RONNY.Models
{
    public class Reservacs
    {

        
            [Key]
            [Required]
            public int ReservaId { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime FechaEntrada { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateTime FechaSalida { get; set; }

            [Required]
            [Precision(28, 2)]  
            public decimal ValorPagar { get; set; }

            
            public int ClienteId { get; set; }
        


    }
}







