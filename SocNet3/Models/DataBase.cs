using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
//Librairie MySQL
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
SocNet3.Utilisateur;


namespace SocNet3.Models
{
    public class DataBase : System.Web.UI.Page
    {

        //String nom, prenom, mail, login, mdp;
        //String nom = RequestNotification.Params[].toString();


        MySqlConnection connexion = new MySqlConnection("database=socnet; server=localhost; user=root; password=azerty");

        public void seConnecter()
        {

            this.connexion.Open();
            
        }

        public void AjouterUtilisateur(Utilisateur utilisateur)
        {
            this.connexion.Open();

            try
            {

                // Création d'une commande SQL en fonction de l'objet connexion
                MySqlCommand cmd = this.connexion.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO Utilisateur (nom, prenom, mail, login, mdp) VALUES (@nom, @prenom, @mail, @login, @mdp)";

                // utilisation de l'objet utilisateur passé en paramètre
                cmd.Parameters.AddWithValue("@nom", utilisateur.nom);
                cmd.Parameters.AddWithValue("@prenom", utilisateur.prenom);
                cmd.Parameters.AddWithValue("@mail", utilisateur.mail);
                cmd.Parameters.AddWithValue("@login", utilisateur.login);
                cmd.Parameters.AddWithValue("@mdp", utilisateur.mdp);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                this.connexion.Close();
            }
            catch
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un boolean en retour pour savoir si le contact à été ajouté correctement.
            }
        }

    }

    }
}