using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocNet3
{
    public class Utilisateur
    {

        public String nom { get; set; }
        public String prenom { get; set; }
        public String mail { get; set; }
        public String login { get; set; }
        public String mdp { get; set; }


        public Utilisateur(String nom, String prenom, String mail, String login, String mdp)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.login = login;
            this.mdp = mdp;
        }

    }
}