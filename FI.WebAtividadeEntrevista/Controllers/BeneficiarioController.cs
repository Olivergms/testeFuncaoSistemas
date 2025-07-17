using FI.AtividadeEntrevista.BLL;
using FI.AtividadeEntrevista.DML;
using System.Collections.Generic;
using System.Web.Mvc;

namespace WebAtividadeEntrevista.Controllers
{
    public class BeneficiarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Listar(long idCliente)
        {
            //List<Beneficiario> ben = new BoBeneficiario().ListaPeloIdCliente(idCliente);
            var list = new List<Beneficiario>
            {
                new Beneficiario{ Id = 1 , CPF = "022.236.212-01", IdCliente = 1, Nome = "Adriano"},
                new Beneficiario{ Id = 2 , CPF = "022.236.212-01", IdCliente = 1, Nome = "Adriano"},
                new Beneficiario{ Id = 3 , CPF = "022.236.212-01", IdCliente = 1, Nome = "Adriano"}
            };

            //Return result to jTable
            return Json(new { Result = "OK", Records = list });
        }
    }
}