using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10.Modele
{
    public class ModeleProjet
    {
        [BsonId]
        public int Id { get; set; }

        [BsonElement("nomProjet")]
        public string nomProjet { get; set; }

        [BsonElement("Mission")]
        public List<ModeleMission> Mission { get; set; }
    }
}

