using Abordo.Data;
using Abordo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Abordo.Controllers
{
    //rota
    [Route("Destinos")]
    public class DestinoController : Controller
    {
        private object novosDadosDestinos;

        //vai listar todos clientes cadastrados
        [HttpGet]
        [Route("Listar")]
        public IActionResult Index()
        {
            var dbContext = new Contexto();
            //vai receber dados com o obj ViewData do bd
            ViewData["Destinos"] = dbContext.Destinos.Where(p => p.IdDestino > 0).ToList();
            return View();
        }

        [HttpPost]
        [Route("Listar")]
        public IActionResult Index(Destino destino)
        {
            var dbContext = new Contexto();
            dbContext.Add(destino);

            //salvar no bd
            dbContext.SaveChanges();

            return RedirectToAction("Index");
            //  return View();
            // return View("Index");
        }

        //excluir
        [HttpPost]
        public IActionResult Deletar(Destino destino)
        {
            var dbcontext = new Contexto();

            var destinoDelete = dbcontext.Destinos.Find(destino.IdDestino);
            dbcontext.Remove(destinoDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }   
        public IActionResult Atualizar(Destino novosDadosDestino)
        {
            var dbcontext = new Contexto();

            var antigosDadosDestino = dbcontext.Destinos.Find(novosDadosDestino.IdDestino);

            antigosDadosDestino.CPFCli = novosDadosDestino.CPFCli;
            antigosDadosDestino.PartidaDestino = novosDadosDestino.PartidaDestino;
            antigosDadosDestino.NomeDestino = novosDadosDestino.NomeDestino;
            antigosDadosDestino.HoraDestino = novosDadosDestino.HoraDestino;
            antigosDadosDestino.DataDestina = novosDadosDestino.DataDestina;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
        

    }
}
