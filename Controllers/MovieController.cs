using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotFlix.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using Notflix.Models;

namespace NotFlix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private IMongoCollection<MoviesModel> _moviesCollection;

        public MovieController(IMongoClient client)
        {
            
            var database = client.GetDatabase("sample_mflix");
            _moviesCollection = database.GetCollection<MoviesModel>("movies");
        }


        // [HttpGet]
        // public IEnumerable<MoviesModel> Get(){
        //     return _moviesCollection.Find(s => s.title =="*").ToList();
        // }

        [HttpGet]
        public IEnumerable<MoviesModel> GetMovies(){
            
            var settings = MongoClientSettings.FromConnectionString("mongodb://dev:<password>@cluster0-shard-00-00.xa0ic.mongodb.net:27017,cluster0-shard-00-01.xa0ic.mongodb.net:27017,cluster0-shard-00-02.xa0ic.mongodb.net:27017/myFirstDatabase?ssl=true&replicaSet=atlas-ggn5gv-shard-0&authSource=admin&retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("sample_mflix");
            var collection = database.GetCollection<BsonDocument>("movies");

            return null;
        }
    }
}
