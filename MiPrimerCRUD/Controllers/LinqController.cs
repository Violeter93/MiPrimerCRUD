using Microsoft.AspNetCore.Mvc;
using MiPrimerCRUD.Models;
using MiPrimerCRUD.Services;

namespace MiPrimerCRUD.Controllers
{
    public class LinqController : Controller
    {
        private MiContexto ctx;
        private IGeneralService general;

        public LinqController(MiContexto ctx, IGeneralService general)
        {
            this.ctx = ctx;
            this.general = general;
        }

        public IActionResult Index( string? filtro)
        {
            var listado = ctx.Asignaturas.Where(asig => asig.Nombre.Contains(filtro) )
                .OrderByDescending(asig => asig.Id)// ordenar de manera descendente
                .Take(2); // número de filas a visualizar
            ViewBag.filtro = filtro;
            return View(listado);
        }
        public IActionResult ListadoCursos( string? filtro, DateTime? fechaDesde, DateTime? fechaHasta)


        {
            var listaCurso = ctx.Cursos.Where(cur => cur.Activo == true);
            if(filtro != null)
            {
                listaCurso = listaCurso.Where(cur => cur.Nombre.Contains(filtro));
            }
            if ( fechaDesde != null)
            {
                listaCurso = listaCurso.Where(cur => DateTime.Compare(cur.FechaInicio.Value, fechaDesde.Value) >= 0);


            } 
            if( fechaHasta != null)
            { 
            listaCurso= listaCurso.Where(cur => DateTime.Compare(cur.FechaInicio.Value, fechaHasta.Value) <= 0);
            }

            ViewBag.fechaDesde = fechaDesde?.ToString("yyyy-MM-dd");
            ViewBag.fechaHasta = fechaHasta?.ToString("yyyy-MM-dd");
            ViewBag.filtro = filtro;
            ViewBag.autor = general.GetAutor();
            return View(listaCurso);
        }
    }
}
