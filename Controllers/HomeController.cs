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

        //Instâncias do tipo cliente//
         Cliente cliente1 = new Cliente(01, "Jorge Franck de O.Alves", "596.251.452-42", "JorgefranckSenai@hotmail.com","Thor");
         Cliente cliente2 = new Cliente(02, "João Alves", "854.221.142-12", "JoãoAlvesSenai@hotmail.com","Princesa");
         Cliente cliente3 = new Cliente(03, "Maria do Socorro Albuquerque", "081.362.485-20", "MariadoSocorroSenai@hotmail.com","Esmeralda");
         Cliente cliente4 = new Cliente(04, "Jucelino Justos Santos", "032.789.510-96", "JucelinoJustosenai@hotmail.com","Timbu");
         Cliente cliente5 = new Cliente(05, "Priscila Calvacantes Pires", "410.263.115-89", "PriPiresSenai@hotmail.com","Thor");


        // lista de clientes e atribui os clientes 
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


         //Instâncias do tipo fornecedor//

        Fornecedor fornecedor1 = new Fornecedor(01, "Pet Shop Boa vista", "15.456.524/0001.41", "PetBoavista@petBoavista.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Dog Bull Pet Shop", "25.444.554/0002.11", "DogBull@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Ovelha Loja Diversos ", "35.578.112/0001.22", "DiversosOvelha@hotmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Comercio de pets em geral", "56.406.858/0001.41", "Comerciopets@pop.com.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Giga embalagens", "36.012.741/0001.00", "GigaEmbalagens@yahoo.com");

         // lista de fornecedor e atribui os fornecedores 
        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
         listaFornecedor.Add(fornecedor1);
         listaFornecedor.Add(fornecedor2);
         listaFornecedor.Add(fornecedor3);
         listaFornecedor.Add(fornecedor4);
         listaFornecedor.Add(fornecedor5);

         ViewBag.listaFornecedor = listaFornecedor;
        
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
