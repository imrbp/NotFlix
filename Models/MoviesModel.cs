using System;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Notflix.Models
{
    public class MoviesModel
    {
        [BsonId]
        public ObjectId id {get;set;}

        
        public string plot { get; set;}

        public Array genres { get; set; }

        public int runtime {get;set;}

        public Array cast {get;set;}

        public string title {get;set;}

        public string fullplot {get;set;}

        public Array languages {get;set;}

        public DateTime released {get;set;}

        public Array directors {get;set;}

        public string rated {get;set;}

        public int year {get;set;}

        public string poster {get;set;}
    }
}