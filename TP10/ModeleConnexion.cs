using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP10.Modele;


namespace TP10
{
    internal class ModeleConnexion
    {
        public static MongoClient client;
        public static IMongoDatabase db;
        public static IMongoCollection<ModeleDeveloppeur> collectionDeveloppeurs;
        public static void seConnecter()
        {
            try
            {
                client = new MongoClient("mongodb://127.0.0.1:27017");
                db = client.GetDatabase("Developpeur");
                MessageBox.Show("MongoDB connecté");
            }
            catch
            {
                MessageBox.Show("Erreur de connexion");
            }
        }


        public static List<ModeleDeveloppeur> RecupDeveloppeurs()
        {
            collectionDeveloppeurs = db.GetCollection<ModeleDeveloppeur>("Developpeur");

            List<ModeleDeveloppeur> lesD = collectionDeveloppeurs.AsQueryable().ToList();
            return lesD;
        }

    }
}
