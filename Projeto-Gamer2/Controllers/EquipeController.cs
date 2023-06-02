using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_Gamer2.Infra;
using Projeto_Gamer2.Models;

namespace Projeto_Gamer2.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        //instancia do contexto para acessar o banco de dados
        Context c = new Context();

        [Route("Listar")]//http://localhost//Equipe//Listar

        public IActionResult Index()
        {
            //variavel que armazena as equipes listadas no banco de dados
            ViewBag.Equipe = c.Equipe.ToList();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();
            // novaEquipe.Imagem = form["Imagem"].ToString();
            //logica de upload
            
            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }
            c.Equipe.Add(novaEquipe);

            c.SaveChanges();
            

            return LocalRedirect("~/Equipe/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
                Equipe equipeBuscada = c.Equipe.FirstOrDefault(e => e.IdEquipe == id);

                c.Remove(equipeBuscada);

                c.SaveChanges();

                return LocalRedirect("~/Equipe/Listar");
        }
        [Route("Editar/{id}")]

        public IActionResult Editar(int id)
        {
            Equipe equipe = c.Equipe.First(x => x.IdEquipe == id);

            ViewBag.Equipe = equipe;

            return View("Edit");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form)
        {
            Equipe equipe = new Equipe();

            equipe.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            equipe.Nome = form["Nome"].ToString();

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                var path = Path.Combine(folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                equipe.Imagem = file.FileName;
            
            }
            else
            {
                equipe.Imagem = "padrao.png";
            }

            Equipe equipebuscada = c.Equipe.First(x => x.IdEquipe == equipe.IdEquipe);
            equipebuscada.Nome = equipe.Nome;
            equipebuscada.Imagem = equipe.Imagem;
            c.Equipe.Update(equipebuscada);
            c.SaveChanges();
            return LocalRedirect("~/Equipe/Listar");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        


    }
}