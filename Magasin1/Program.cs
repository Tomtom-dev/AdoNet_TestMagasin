using System;
using System.Data.SqlClient;

namespace Magasin1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
                {

                    // Chaine de connexion
                    string chaineDeConnexion = @"Data Source=(LocalDb)\magasin ; Integrated Security=True";

                    // utilisation de using pour la connexion et interaction avec la DB
                    using(SqlConnection connection = new SqlConnection(chaineDeConnexion))
                        {
                            // Ouverture de la connexion
                            connection.Open();
                            // Requetes
                            string requete = "INSERT INTO produit (nom, prix, stock) values ('pommes', 15, 100)";
                            string requete1 = "SELECT * FROM produit";

                            // SQL COmmand pour envoyer les requetes
                            SqlCommand cmdInsert = new SqlCommand(requete, connection);
                            SqlCommand cmdRead = new SqlCommand(requete1, connection);

                            /*cmd.CommandType = System.Data.CommandType.Text;
                            cmd.ExecuteNonQuery();*/

                            // SQL DataReader pour executer les requetes 
                            SqlDataReader read = cmd.ExecuteReader();
                        }
              

                    
                }
            catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                
        }
    }
}
