using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace WebEncuesta_LP.ViewModel
{
    public class CategoriasViewModels
    {

        [Display(Name = "Encuesta")]
        [Required(ErrorMessage ="La categoria es requerida")]
        public int Categoriaid { get; set; }

        [Display(Name = "Pregunta")]
        [Required(ErrorMessage = "La pregunta es requerida")]
        public string Pregunta {get; set;}

        public string NombreOpcion { get; set; }

        public string Categoria { get; set;} 

            public IEnumerable<SelectListItem>  ListaOfCategoria{ get; set; }


    }
}