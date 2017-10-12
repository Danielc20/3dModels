using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCModelos3d.Models.Modelos3d
{
    public class Modelo3d
    {
        [Display(Name = "Titulo del Modelo 3D")]
        public string Titulo { get; set; }
        [Display(Name = "Descripcción")]
        public string Descripcion { get; set; }
        [Display(Name = "Precio del Modelo 3D", Description = "Precio del Modelo en Dolares")]
        [DataType(DataType.Currency)]
        public float Precio { get; set; }

        public ApplicationUser userObj { get; set; }

        //prop Foto del Modelo3d
    }
}