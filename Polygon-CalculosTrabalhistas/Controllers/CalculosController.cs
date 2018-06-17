using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Polygon.Domain.Model;

namespace Polygon.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CalculosController : Controller
    {
        [HttpGet]
        public IActionResult Calcular(int matricula, double valorHora, double horasTrabalhadas)
        {
            Funcionario f = new Funcionario(matricula, valorHora, horasTrabalhadas);
            Calculo calc = new Calculo(f);

            double salarioBruto = calc.CalcularSalarioBruto(f.ValorHora, f.HorasTrabalhadas);

            return Ok(salarioBruto);
        }
    }
}