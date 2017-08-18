using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ulatina.PruebaProyecto.Models
{
    public partial class Student
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }

    [MetadataType(typeof(Student.StudentMetaData))]
    public partial class Student
    {
        public class StudentMetaData
        {
            [Required(ErrorMessage = "Ingrese un número de cédula")]
            [StringLength(9, ErrorMessage = "El máximo de caracteres permitido es 9")]
            [DisplayAttribute(Name = "Cédula")]
            public int Cedula { get; set; }

            [Required(ErrorMessage = "Ingrese un nombre")]
            [DisplayAttribute(Name = "Nombre completo")]
            public string Nombre { get; set; }

            [Required(ErrorMessage = "Ingrese la fecha de nacimiento.")]
            [DisplayAttribute(Name = "Fecha de nacimiento")]
            [DataType(DataType.Date)]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
            public DateTime FechaNacimiento { get; set; }

            [Required(ErrorMessage = "Ingrese un tipo de genero")]
            [DisplayFormat(NullDisplayText = "No se especifico el género.")]
            [DisplayAttribute(Name = "Género")]
            public string Genero { get; set; }

            [Required(ErrorMessage = "Ingrese un email")]
            [DataType(DataType.EmailAddress)]
            [EmailAddress]
            [DisplayAttribute(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Ingrese una dirección")]
            [DataType(DataType.MultilineText)]
            [StringLength(20, ErrorMessage = "El máximo de caracteres permitido es 20")]
            [DisplayAttribute(Name = "Dirección")]
            public string Direccion { get; set; }

            [Required(ErrorMessage = "Ingrese una telefono")]
            [StringLength(8, ErrorMessage = "El máximo de caracteres permitido es 8")]
            [DisplayAttribute(Name = "Teléfono")]
            public string Telefono { get; set; }
        }
    }

    


}