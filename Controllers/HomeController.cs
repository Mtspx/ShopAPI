using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projetoMVC_C_.Models;
using System.Net;

namespace projetoMVC_C_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    private Boolean usuario_logado = true;
    public ViewResult Index()
    {
        return View();
    }
    public ViewResult Fotos(int? id)
    {
        return View();
    }
    public ViewResult Mensagem(int? id)
    {
        return View();

    }

    public ViewResult Chamado(int? id)
    {
        return View();
    }

    public ViewResult Login(int? id)
    {
        return View();
    }

    public ViewResult Cartas(int? id)
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string usuario, string senha)
    {
        if (usuario == "meuamor")
        {
            if (senha == "euteamo")
            {
                usuario_logado = true;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }
        else
        {
            return RedirectToAction("Login", "Home");
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}
