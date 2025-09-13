using JPWeb.Models;
using Microsoft.AspNetCore.Mvc;
namespace JPWeb.Controllers

{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ValidaUsuario(Usuario usuario)
        {
            try
            {
                if (usuario.Email == "davi@gmail.com" && usuario.Senha == "davi123")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["MensagemErro"] = "Usuário ou senha inválidos!";
                }
            }
            catch (Exception e)
            {

                throw;
            }
            return View();
        }
    }
}
