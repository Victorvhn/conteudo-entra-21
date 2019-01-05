using Exercicio01.Models;
using Exercicio01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Exercicio01.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        [HttpGet]
        public ActionResult Index()
        {
            List<Aluno> alunos = new AlunoRepository().ObterTodos();
            ViewBag.Alunos = alunos;
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.Aluno = new Aluno();
            return View();
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Aluno aluno = new AlunoRepository().ObterPeloId(id);
            ViewBag.Aluno = aluno;
            return View();
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            bool apagado = new AlunoRepository().Excluir(id);
            return null;
        }

        [HttpPost]
        public ActionResult Store(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                int identificador = new AlunoRepository().Cadastrar(aluno);
                return RedirectToAction("Editar", new { id = identificador });
            }

            ViewBag.Aluno = aluno;
            return View("Cadastro");
        }

        [HttpPost]
        public ActionResult Update(Aluno aluno)
        {
            bool alterado = new AlunoRepository().Alterar(aluno);
            return RedirectToAction("Index");
        }
    }
}