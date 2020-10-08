using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteTecnicoWebCoreJogador.Models;

namespace TesteTecnicoWebCoreJogador.Controllers
{
    public class JogadorController : Controller
    {
        // GET: Jogador
        public IActionResult Index()
        {
            using (JogadorModel model = new JogadorModel())
            {
                List<Jogador> lista = model.Read();
                return View(lista);
            }
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            using (JogadorModel model = new JogadorModel())
            {
                Jogador jogador = model.GetJogador(id);
                return View(jogador);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            Jogador jogador = new Jogador();
            jogador.Nome = form["Nome"];
            jogador.Idade = Convert.ToInt32(form["Idade"]);
            jogador.NumeroCamisa = Convert.ToInt32(form["NumeroCamisa"]);
            jogador.GolsMarcados = Convert.ToInt32(form["GolsMarcados"]);

            using (JogadorModel model = new JogadorModel())
            {
                model.Create(jogador);
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            

            using (JogadorModel model = new JogadorModel())
            {
                Jogador jogador = model.GetJogador(id);
                return View(jogador);
            }
        }

        [HttpPost]
        public IActionResult Update(int? id, [Bind]Jogador jogador){           

            using (JogadorModel model = new JogadorModel())
            {
                model.Update(jogador);
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Jogador jogador = new Jogador();
            using (JogadorModel model = new JogadorModel())
            {
                jogador = model.GetJogador(id);
                return View(jogador);
            }

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id, [Bind]Jogador jogador)
        {
            
            using (JogadorModel model = new JogadorModel())
            {
                model.Delete(id);
                return RedirectToAction("Index");
            }
        }

        
    }

}
