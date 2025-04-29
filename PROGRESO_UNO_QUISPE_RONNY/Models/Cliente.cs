using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace PROGRESO_UNO_QUISPE_RONNY.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(10)]
        public string Nombre { get; set; }

        [Required]
        [Precision(28,2)]
        [Range(0, 10000)]

        public decimal Saldo { get; set; }      

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }

        [Phone]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

    }
}
