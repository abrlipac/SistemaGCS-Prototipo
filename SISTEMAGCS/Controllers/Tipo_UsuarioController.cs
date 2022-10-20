using SISTEMAGCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SISTEMAGCS.Controllers
{
    public class Tipo_UsuarioController : Controller
    {

        private Tipo_Usuario objTipoUsuario = new Tipo_Usuario();
        
        public ActionResult Index()
        {
            return View(objTipoUsuario.Listar());
        }

        public ActionResult Agregar()
        {
            return View();        
        }
    }
}