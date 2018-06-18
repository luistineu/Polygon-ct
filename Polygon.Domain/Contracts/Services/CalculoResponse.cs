using System;
using System.Collections.Generic;
using System.Text;
using Polygon.Domain.Model;

namespace Polygon.Domain.Contracts.Services
{
    public class CalculoResponse
    {
        public Funcionario funcionario { get; set; }
        public double HorasTrabalhadas { get; set; }
    }
}
