using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace AbmPaises.Web.Data.Entities
{
    public class Provincia
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Provincia")]
        public string NombreProvincia { get; set; }
        
        

        //esta entitie Pertenece a:
        public Pais Pais { get; set; }

    }
}
