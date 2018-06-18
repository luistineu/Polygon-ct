using System;
using System.Collections.Generic;
using System.Text;
using Polygon.Domain.Model;

namespace Polygon.Domain.Contracts.Repositories
{
    public interface ICalculosRepository
    {
        IEnumerable<Calculo> List();
        IEnumerable<Calculo> FindByMatricula(int matricula);
        IEnumerable<Calculo> FindByMatriculaEMes(int matricula, int mes);
        IEnumerable<Calculo> FindByMes(int mes);
        void Save(Calculo calculo);
        void Remove(Calculo calculo);
    }
}
