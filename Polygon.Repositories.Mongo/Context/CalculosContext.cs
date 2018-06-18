using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using Polygon.Domain.Model;

namespace Polygon.Repositories.Mongo.Context
{
    public class CalculosContext
    {
        private readonly IMongoClient _database;

        public CalculosContext()
        {
            _database = ConnectionFactory.Build();
        }

        public IMongoCollection<Calculo> Calculos =>
            _database.GetDatabase("DBCalculos").GetCollection<Calculo>("Calculos");
    }
}
