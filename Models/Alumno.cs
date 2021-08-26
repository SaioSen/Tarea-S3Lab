using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Tarea_S3Lab.Models
{

    [Table("t_alumno")]



    public class Alumno
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("id")]
        public int Id { get; set; }


        [Column("nombres")]
        public string Nombres { get; set;}

        [Column("apellidos")]
        public string Apellidos { get; set;}

        [Column("FechaNaci")]
        public DateTime Time { get; set;}

        [Column("dni")]
        public int DNI { get; set;}

        [Column("genero")]
        public string Genero { get; set;}
        [Column("carrera")]

        public string Carrera { get; set;}
    }

}