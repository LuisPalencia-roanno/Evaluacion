using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEncuesta_LP.Models;
using WebEncuesta_LP.ViewModel;
using System.Web.Security;


namespace WebEncuesta_LP.Controllers
{
    public class CuentaController : Controller
    {
        private EncuestaEntities objDBEntiry;

        public CuentaController()
        {
            objDBEntiry = new EncuestaEntities();
        }


        // GET: Cuenta
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AdminViewModel objAdminViewModel)
        {
            Administracion oAdmin = objDBEntiry.Administracion.SingleOrDefault(model => model.NombreUsuario == objAdminViewModel.NombreUsuario);
            if (ModelState.IsValid)
            {
               // Administracion oAdmin = objDBEntiry.Administracion.SingleOrDefault(model => model.NombreUsuario == objAdminViewModel.NombreUsuario);

                if (oAdmin == null)
                {
                    ModelState.AddModelError(key: string.Empty, errorMessage: "Correo no existe");
                }
                else if (oAdmin.Contraseña != objAdminViewModel.Contrasena)
                {
                    ModelState.AddModelError(key: string.Empty, errorMessage: "Correo y Contraseña invalida");
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(objAdminViewModel.NombreUsuario, createPersistentCookie:false);
                    var authTicket = new FormsAuthenticationTicket(1,oAdmin.NombreUsuario,  DateTime.Now, expiration: DateTime.Now.AddMinutes(20), isPersistent: false, userData: "Admin");

                    string encryptTicket = FormsAuthentication.Encrypt(authTicket);

                    var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptTicket);


                    HttpContext.Response.Cookies.Add(authCookie);

                    return RedirectToAction("Index", "Admin");

                }
            }
            return View();
        }

    }
}