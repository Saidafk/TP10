using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10.Modele
{
    public class ModeleMission
    {
        [BsonId]
        public int Id { get; set; }

        [BsonElement("dateDeDebut")]
        public string dateDeDebut { get; set; }
        [BsonElement("dateDeFinPrevisionnelle")]
        public string dateDeFinPrevisionnelle { get; set; }
        [BsonElement("dateDeFinReelle")]
        public string dateDeFinReelle { get; set; }
        [BsonElement("chefProjet")]
        public string chefProjet { get; set; }

        [BsonElement("Etat")]
        public string Etat { get; set; }
    }
}
