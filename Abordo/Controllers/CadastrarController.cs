using Abordo.Models;
using Abordo.Data;
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
    [Route("Cadastrars")]
    public class CadastrarController : Controller
    {
        //vai listar todos clientes cadastrados
        [HttpGet]
        [Route("Listar")]
        public IActionResult Index()
        {
            var dbContext = new Contexto();
            //vai receber dados com o obj ViewData do bd
            ViewData["Cadastrars"] = dbContext.Cadastrars.Where(p => p.IdCli > 0).ToList();
            return View();
        }
        public IActionResult Cad()
        {
            return View();
        }

        [HttpPost]
        [Route("Listar")]
        public IActionResult Index(Cadastrar cadastrar)
        {
            var dbContext = new Contexto();
            dbContext.Add(cadastrar);

            //salvar no bd
            dbContext.SaveChanges();

            return RedirectToAction("Index");
            //  return View();
            // return View("Index");
        }
        //excluir
        [HttpPost]
        public IActionResult Deletar(Cadastrar cadastrar)
        {
            var dbcontext = new Contexto();

            var cadastrarDelete = dbcontext.Cadastrars.Find(cadastrar.IdCli);
            dbcontext.Remove(cadastrarDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Atualizar(Cadastrar novosDadosCadastrar)
        {
            var dbcontext = new Contexto();

            var antigosDadosCadastrar= dbcontext.Cadastrars.Find(novosDadosCadastrar.IdCli);

            antigosDadosCadastrar.NomeCli = novosDadosCadastrar.NomeCli;
            antigosDadosCadastrar.CPFCli = novosDadosCadastrar.CPFCli;
            antigosDadosCadastrar.NasCli = novosDadosCadastrar.NasCli;
            antigosDadosCadastrar.CEPCli = novosDadosCadastrar.CEPCli;
            antigosDadosCadastrar.BairroCli = novosDadosCadastrar.BairroCli;
            antigosDadosCadastrar.EnderecoCli = novosDadosCadastrar.EnderecoCli;
            antigosDadosCadastrar.NumeroCli = novosDadosCadastrar.NumeroCli;
            antigosDadosCadastrar.TelefoneCli = novosDadosCadastrar.TelefoneCli;
            antigosDadosCadastrar.EmailCli = novosDadosCadastrar.EmailCli;
            antigosDadosCadastrar.Situacao = novosDadosCadastrar.Situacao;



            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
   
    }
