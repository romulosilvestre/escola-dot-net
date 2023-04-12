using AplicativoWeb.Models; //camada Model
using Microsoft.AspNetCore.Mvc; //Microsoft
namespace AplicativoWeb.Controllers;//Definindo
//Criamos a classe Controller
public class CursoController:Controller{
     public IActionResult Index(){
        Curso c1 = new Curso();
        //set
        c1.Descricao = "Primeiros Passos no ASP.NET Core";
        c1.TituloInterno = "Desenvolvedor C#";
        c1.TituloMarketing = "Crie Aplicativos Incríveis";
        
        //get
        ViewData["desc"] = c1.Descricao;
        ViewData["titInt"] = c1.TituloInterno;
        ViewData["titMark"] = c1.TituloMarketing;
        return View();
    }
}