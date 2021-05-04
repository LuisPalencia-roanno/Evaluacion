using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEncuesta_LP.Models;
using WebEncuesta_LP.ViewModel;


namespace WebEncuesta_LP.Controllers
{
    public class AdminController : Controller
    {
        private EncuestaEntities objdbEntities;

        public AdminController ()
        {
            objdbEntities = new EncuestaEntities();
        }


        // GET: Admin
        public ActionResult Index()
        {
            CategoriasViewModels objCategoriaViewMOdel = new CategoriasViewModels();

            objCategoriaViewMOdel.ListaOfCategoria = (from objCat in objdbEntities.Enc_Categorias
                                                    select new SelectListItem()
                                                    {
                                                        Value = objCat.CategoriaId.ToString(),
                                                        Text = objCat.NombreCategoria
                                                    }).ToList();
            
            return View(objCategoriaViewMOdel);
        }

        [HttpPost]
        public JsonResult Index(QuestionOptionsViewModel objQuestionOptionModel)
        {

            Enc_Preguntas objPreguntas = new Enc_Preguntas();
            objPreguntas.Pregunta = objQuestionOptionModel.Question;
            objPreguntas.CategoriaId = objQuestionOptionModel.CategoryId;
            objPreguntas.Activo = true;
            objPreguntas.Multiple = false;

            objdbEntities.Enc_Preguntas.Add(objPreguntas);
            objdbEntities.SaveChanges();

            int questionid = objPreguntas.PreguntaId;

           // foreach( var item  in objQuestionOptionModel.ListofOptions)
          //  {
          //      option objOption = new EncuestaEntities;
         //       objOption.OptionName = item;
         //       objOption.
          //  }

            return Json( new { message = "Datos agregados", success = true }, JsonRequestBehavior.AllowGet);

        }
    }
}