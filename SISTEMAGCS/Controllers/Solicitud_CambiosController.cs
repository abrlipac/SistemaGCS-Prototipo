using SISTEMAGCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SISTEMAGCS.Controllers
{
    public class Solicitud_CambiosController : Controller
    {
        // GET: SolicitudCambios
        public ActionResult Index()
        {
            Proyecto proyecto = new Proyecto() { Nombre = "Sistema de ventas" };
            Solicitud solicitud = new Solicitud() { Requerimiento = "RF-002 Cambiar estado de cliente" };


            var solicitudesCambios = new List<Solicitud_Cambios>();
            solicitudesCambios.Add(new Solicitud_Cambios() { Id_solicitud_cambios = 1, Fecha = "20/10/2022", Objetivo = "Actualizar RF-002 del Sistema de ventas", Descripcion = "Actualizar RF-002 del Sistema de ventas", Respuesta = "Positiva", Id_solicitud = 1, Solicitud = solicitud, Proyecto = new List<Proyecto>().Append(proyecto).ToList() });
            solicitudesCambios.Add(new Solicitud_Cambios() { Id_solicitud_cambios = 2, Fecha = "19/10/2022", Objetivo = "Actualizar RF-004 del Sistema de ventas", Descripcion = "Actualizar RF-004 del Sistema de ventas", Respuesta = "Negativa", Id_solicitud = 2, Solicitud = solicitud, Proyecto = new List<Proyecto>().Append(proyecto).ToList() });
            solicitudesCambios.Add(new Solicitud_Cambios() { Id_solicitud_cambios = 3, Fecha = "20/10/2022", Objetivo = "Actualizar RF-003 del Sistema de matrículas", Descripcion = "Actualizar RF-003 del Sistema de matrículas", Respuesta = "Positiva", Id_solicitud = 3, Solicitud = solicitud, Proyecto = new List<Proyecto>().Append(proyecto).ToList() });

            return View(solicitudesCambios);
        }

        public ActionResult Agregar(int id = 0)
        {
            var tiposSolicitud = new List<Solicitud>();
            tiposSolicitud.Add(new Solicitud() { Id_solicitud = 1, Requerimiento = "Ventas", Descripcion = "Actualizar Requerimiento" });
            tiposSolicitud.Add(new Solicitud() { Id_solicitud = 1, Requerimiento = "Matrículas", Descripcion = "Actualizar Requerimiento" });

            ViewBag.TiposSolicitud = tiposSolicitud;

            Proyecto proyecto = new Proyecto() { Nombre = "Sistema de ventas" };
            Solicitud solicitud = new Solicitud() { Requerimiento = "RF-002 Cambiar estado de cliente" };

            var solicitudesCambios = new List<Solicitud_Cambios>();
            solicitudesCambios.Add(new Solicitud_Cambios() { Id_solicitud_cambios = 1, Fecha = "20/10/2022", Objetivo = "Actualizar RF-002 del Sistema de ventas", Descripcion = "Actualizar RF-002 del Sistema de ventas", Respuesta = "Positiva", Id_solicitud = 1, Solicitud = solicitud, Proyecto = new List<Proyecto>().Append(proyecto).ToList() });
            solicitudesCambios.Add(new Solicitud_Cambios() { Id_solicitud_cambios = 2, Fecha = "19/10/2022", Objetivo = "Actualizar RF-004 del Sistema de ventas", Descripcion = "Actualizar RF-004 del Sistema de ventas", Respuesta = "Negativa", Id_solicitud = 2, Solicitud = solicitud, Proyecto = new List<Proyecto>().Append(proyecto).ToList() });
            solicitudesCambios.Add(new Solicitud_Cambios() { Id_solicitud_cambios = 3, Fecha = "20/10/2022", Objetivo = "Actualizar RF-003 del Sistema de matrículas", Descripcion = "Actualizar RF-003 del Sistema de matrículas", Respuesta = "Positiva", Id_solicitud = 3, Solicitud = solicitud, Proyecto = new List<Proyecto>().Append(proyecto).ToList() });

            return View(id == 0 ? new Solicitud_Cambios() : solicitudesCambios.Find(x => x.Id_solicitud_cambios == id));
        }
    }
}