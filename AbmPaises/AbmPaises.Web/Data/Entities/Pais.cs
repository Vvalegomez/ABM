using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbmPaises.Web.Data.Entities
{
    public class Pais
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Pais")]
        public string NombrePais { get; set; }
 
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Provincia")]
        public string NombreProvincia { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Ciudad")]
        public string NombreCiudad { get; set; }

        //Esta entitie se relaciona con:
        public ICollection<Provincia> Provincias { get; set; }
        //Esta entitie se relaciona con:
        public ICollection<Ciudad> Ciudades { get; set; }
    }
}
