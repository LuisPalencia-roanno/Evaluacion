using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebEncuesta_LP.ViewModel
{
    public class AdminViewModel
    {
        [Display(Name="Email")]
        [Required(ErrorMessage = "e-mail es requerido")]
        [EmailAddress(ErrorMessage = "ingrese un e-mail válido")]

        public string NombreUsuario { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "El password es requerido")]
        [DataType(DataType .Password)]

        public string Contrasena { get; set; }

    }
}