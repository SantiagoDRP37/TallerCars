using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(7)")]
        public string matricula { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string celular { get; set; }


    }
}
