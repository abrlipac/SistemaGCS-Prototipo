using SISTEMAGCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SISTEMAGCS.Controllers
{
    public class UsuarioController : Controller
    {
        private Usuario objUsuario=new Usuario();
        private Tipo_Usuario objTipo=new Tipo_Usuario();


        // GET: Usuario
        public ActionResult Index()
        {
            return View(objUsuario.Listar());
        }

        public ActionResult Agregar()
        {
            return View();
        }
    }
}