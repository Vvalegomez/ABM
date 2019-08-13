using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbmPaises.Web.Data.Entities
{
    public class Ciudad
    {
        public int Id { get; set; }

        [Display(Name = "Ciudad")]
        public string NombreCiudad { get; set; }

        //esta entitie pertenece a:
        public Provincia Provincia { get; set; }

    }
}
