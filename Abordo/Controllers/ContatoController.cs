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
    [Route("Contatos")]
    public class ContatoController : Controller
    {
        //vai listar todos clientes cadastrados
        [HttpGet]
        [Route("Listar")]
        public IActionResult Index()
        {
            var dbContext = new Contexto();
            //vai receber dados com o obj ViewData do bd
            ViewData["Contatos"] = dbContext.Contatos.Where(p => p.IdContato > 0).ToList();
            return View();
        }

        [HttpPost]
        [Route("Listar")]
        public IActionResult Index(Contato contato)
        {
            var dbContext = new Contexto();
            dbContext.Add(contato);

            //salvar no bd
            dbContext.SaveChanges();

            return RedirectToAction("Index");
            //  return View();
            // return View("Index");
        }
        //excluir
        [HttpPost]
        public IActionResult Deletar(Contato contato)
        {
            var dbcontext = new Contexto();

            var contatoDelete = dbcontext.Destinos.Find(contato.IdContato);
            dbcontext.Remove(contatoDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Atualizar(Contato novosDadosContato)
        {
            var dbcontext = new Contexto();

            var antigosDadosContato = dbcontext.Contatos.Find(novosDadosContato.IdContato);

            antigosDadosContato.NomeContato = novosDadosContato.NomeContato;
            antigosDadosContato.EmailContato = novosDadosContato.EmailContato;
            antigosDadosContato.MsgContato = novosDadosContato.MsgContato;
            

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }

}
