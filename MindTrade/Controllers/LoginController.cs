using Microsoft.AspNetCore.Mvc;
using MindTrade.Models;
using MindTrade.Data;
using System;
using Microsoft.EntityFrameworkCore;
using MindTrade.Helper;

namespace MindTrade.Controllers
{
    public class LoginController : Controller
    {
        //Adiciona o contexto do banco de dados
        private readonly MindTradeContext _context;
        private readonly ISessao _sessao;
        public LoginController(MindTradeContext context, 
                               ISessao sessao)
        {
            _context = context;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            //Se o usuario estiver logado, redirecionar para a home
            if(_sessao.BuscarSessaoDoUsuario() != null) return RedirectToAction("Index", "Home");

            return View();
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoDoUsuario();

            return RedirectToAction("Index", "Login");
        }

        //Verifica se os dados inseridos no formulário de login é encontrado no banco de dados
        [HttpPost] 
        public async Task<IActionResult> Entrar(LoginModel loginModel) 
        { 
            if (ModelState.IsValid) 
            { 
                var usuario = await _context.Usuarios 
                    .FirstOrDefaultAsync(u => u.Email == loginModel.Email); 

                if (usuario != null && usuario.Senha == loginModel.Senha) 
                { 
                    _sessao.CriarSessaoDoUsuario(usuario);
                    // Redirecionar para a página inicial
                    return RedirectToAction("Index", "Home"); 
                } 

                TempData["MensagemErro"] = "Email e/ou senha inválido(s). Por favavor, tente novamente.";
            } 

            return View("Index"); }

    }
}
