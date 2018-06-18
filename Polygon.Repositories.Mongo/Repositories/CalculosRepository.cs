using System;
using System.Collections.Generic;
using System.Text;
using Polygon.Domain.Contracts.Repositories;
using Polygon.Domain.Model;
using Polygon.Repositories.Mongo.Context;

namespace Polygon.Repositories.Mongo.Repositories
{
    public class CalculosRepository : ICalculosRepository
    {
        private readonly CalculosContext _context;

        public CalculosRepository(CalculosContext context)
        {
            _context = context;
        }

        public IEnumerable<Calculo> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Calculo> FindByMatricula(int matricula)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Calculo> FindByMatriculaEMes(int matricula, int mes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Calculo> FindByMes(int mes)
        {
            throw new NotImplementedException();
        }

        public void Save(Calculo calculo)
        {
            throw new NotImplementedException();
        }

        public void Remove(Calculo calculo)
        {
            throw new NotImplementedException();
        }
    }
}
