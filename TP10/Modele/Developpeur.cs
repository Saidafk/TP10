using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace TP10.Modele
{
    public class ModeleDeveloppeur
    {
        [BsonId]
        public int Id { get; set; }
        [BsonElement("nom")]
        public string nom { get; set; }
        [BsonElement("prenom")]
        public string prenom { get; set; }
        [BsonElement("descriptif")]
        public string descriptif { get; set; }
        [BsonElement("Projet")]
        public List<ModeleProjet> Projet { get; set; }
        [BsonElement("qualification")]
        public List<qualification> qualification { get; set; }
    }

    public class qualification
    {
        [BsonId]
        public int Id { get; set; }

        [BsonElement("diplome")]
        public string diplome { get; set; }
        [BsonElement("dateObtention")]
        public string dateObtention { get; set; }
    }

    

}
