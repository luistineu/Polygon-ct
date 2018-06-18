using System;
using System.Collections.Generic;
using System.Text;
using Polygon.Domain.Model;

namespace Polygon.Domain.Contracts.Services
{
    public interface ICalculosService
    {
        CalculoResponse CalcularSalario(CalculoRequest request);
    } 
}
