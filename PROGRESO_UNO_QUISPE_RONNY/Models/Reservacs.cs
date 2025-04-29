using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PROGRESO_UNO_QUISPE_RONNY.Models
{
    public class Reservacs
    {
            
        [Key]
        public int ReservaId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [MaxLength(10)]
        public DateTime FechaEntrada { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime FechaSalida { get; set; }

        [Required]
        [Precision(28, 2)]
        [MaxLength(20)]
        public decimal ValorPagar { get; set; }

        // relacion con cliente
        public int ClienteId { get; set; }
            
        }
    }







