using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancia cliente
       Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-14","arthur@gmail.br.top","toiaoo");
       Cliente cliente2 = new Cliente(02, "Alice A. Ferreira", "657.032.950-14","alice@gmail.br.top","dog");
       Cliente cliente3 = new Cliente(03, "Monica A. Ferreira", "757.032.950-14","momica@gmail.br.top","cao");
       Cliente cliente4 = new Cliente(04, "Eduardo A. Ferreira", "557.032.950-14","edu@gmail.br.top","TOt");
       Cliente cliente5 = new Cliente(05, "Marcos A. Ferreira", "057.032.950-14","ferreira@gmail.br.top","Bebel");

        //lista de clientes e atribuir clientes 
       List<Cliente>listaClientes = new List<Cliente>();
       listaClientes.Add(cliente1);
       listaClientes.Add(cliente2);
       listaClientes.Add(cliente3);
       listaClientes.Add(cliente4);
       listaClientes.Add(cliente5);

       ViewBag.listaClientes = listaClientes;

       // instancia Fornecedor e atribuir fornecedores 
       Fornecedor fornecedor1 = new Fornecedor(01,"joao pet s/a","14.182.190/0001-00",  "ctr-sharp@.br");
       Fornecedor fornecedor2 = new Fornecedor(02,"carlos pet s/a","15.182.190/0001-00", "crft-sharp@.br");
       Fornecedor fornecedor3 = new Fornecedor(03,"andre pet s/a","16.182.190/0001-00", "cfr-sharp@.br");
       Fornecedor fornecedor4 = new Fornecedor(04,"antonio pet s/a","17.182.190/0001-00", "bg-sharp@.br");
       Fornecedor fornecedor5 = new Fornecedor(05,"cleber pet s/a","18.182.190/0001-00", "as-sharp@.br");

        //lista de Fornecedor
       List<Fornecedor> listaFornecedores = new List<Fornecedor>();
       listaFornecedores.Add(fornecedor1);
       listaFornecedores.Add(fornecedor2);
       listaFornecedores.Add(fornecedor3);
       listaFornecedores.Add(fornecedor4);
       listaFornecedores.Add(fornecedor5);

       ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
