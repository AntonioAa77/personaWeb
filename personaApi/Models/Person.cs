using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace personaApi.Models
{
    public enum SexType
    {
        Femenino = 0,
        Masculino = 1,
    }
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Por favor ingrese entre 5 a 60 caracteres")]
        [Display(Name = "Nombre de la persona")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Sexo")]
        public SexType Sex { get; set; }
        [Display(Name = "Pasa Tiempo")]
        public string Hobbie { get; set; }


    }
}
