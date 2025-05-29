using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les développeurs
    /// </summary>
    public class DeveloppeurAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public DeveloppeurAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les développeurs avec un filtre optionnel par profil
        /// </summary>
        /// <param name="idProfil">Identifiant du profil à filtrer (ou null pour aucun filtre)</param>
        /// <returns>Liste de développeurs</returns>
        public List<Developpeur> GetLesDeveloppeurs(int? idProfil = null)
        {
            // 1) Constitution de la requête (on récupère désormais tel et mail)
            string requete = @"
                SELECT d.iddeveloppeur, d.nom, d.prenom, d.tel, d.mail,
                       p.idprofil, p.nom
                  FROM developpeur d
             INNER JOIN profil      p ON d.idprofil = p.idprofil";
            if (idProfil.HasValue)
            {
                requete += " WHERE d.idprofil = @idProfil";
            }

            // 2) Préparation des paramètres
            var parameters = new Dictionary<string, object>();
            if (idProfil.HasValue)
            {
                parameters.Add("@idProfil", idProfil.Value);
            }

            // 3) Exécution via access.Manager (au lieu de Manager tout seul)
            var records = access.Manager.ReqSelect(requete, parameters);

            // 4) Mapping des résultats vers les objets métier
            var liste = new List<Developpeur>();
            foreach (object[] a in records)
            {
                int id = (int)a[0];
                string nom = a[1]?.ToString();
                string prenom = a[2]?.ToString();
                string tel = a[3]?.ToString();
                string mail = a[4]?.ToString();
                var profil = new Profil((int)a[5], a[6]?.ToString());
                liste.Add(new Developpeur(id, nom, prenom, tel, mail, profil));
            }

            return liste;
        }

        /// <summary>
        /// Demande de suppression d'un développeur
        /// </summary>
        /// <param name="developpeur">objet developpeur à supprimer</param>
        public void DelDepveloppeur(Developpeur developpeur)
        {
            if (access.Manager != null)
            {
                string req = "delete from developpeur where iddeveloppeur = @iddeveloppeur;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@iddeveloppeur", developpeur.Iddeveloppeur);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande d'ajout un développeur
        /// </summary>
        /// <param name="developpeur">objet developpeur à ajouter</param>
        public void AddDeveloppeur(Developpeur developpeur)
        {
            if (access.Manager != null)
            {
                string req = "insert into developpeur(nom, prenom, tel, mail, pwd, idprofil) ";
                req += "values (@nom, @prenom, @tel, @mail, SHA2(@pwd, 256), @idprofil);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", developpeur.Nom);
                parameters.Add("@prenom", developpeur.Prenom);
                parameters.Add("@tel", developpeur.Tel);
                parameters.Add("@mail", developpeur.Mail);
                parameters.Add("@pwd", developpeur.Nom);
                parameters.Add("@idprofil", developpeur.Profil.Idprofil);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'un développeur
        /// </summary>
        /// <param name="developpeur">objet developpeur à modifier</param>
        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            if (access.Manager != null)
            {
                string req = "update developpeur set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idprofil = @idprofil ";
                req += "where iddeveloppeur = @iddeveloppeur;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idDeveloppeur", developpeur.Iddeveloppeur);
                parameters.Add("@nom", developpeur.Nom);
                parameters.Add("@prenom", developpeur.Prenom);
                parameters.Add("@tel", developpeur.Tel);
                parameters.Add("@mail", developpeur.Mail);
                parameters.Add("@idprofil", developpeur.Profil.Idprofil);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification du pwd
        /// </summary>
        /// <param name="developpeur">objet developpeur avec nouveau pwd</param>
        public void UpdatePwd(Developpeur developpeur)
        {
            if (access.Manager != null)
            {
                string req = "update developpeur set pwd = SHA2(@pwd, 256) ";
                req += "where iddeveloppeur = @iddeveloppeur;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idDeveloppeur", developpeur.Iddeveloppeur);
                parameters.Add("@pwd", developpeur.Pwd);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    /// <summary>
    /// Vérifie qu’un développeur de profil "admin" existe pour le nom, prénom et mot de passe fournis.
    /// </summary>
    /// <param name="admin">Objet Admin contenant Nom, Prenom et Pwd en clair</param>
    /// <returns>true si l’authentification est valide et que le profil est "admin"</returns>
    public bool ControleAuthentification(Admin admin)
        {
            const string sql = @"
        SELECT COUNT(*)
          FROM developpeur d
     INNER JOIN profil p ON d.idprofil = p.idprofil
         WHERE d.nom       = @nom
           AND d.prenom    = @prenom
           AND d.pwd       = SHA2(@pwd, 256)
           AND p.nom = 'admin'";

            var parameters = new Dictionary<string, object>
            {
                ["@nom"] = admin.Nom,
                ["@prenom"] = admin.Prenom,
                ["@pwd"] = admin.Pwd
            };

            // exécution de la requête
            var records = access.Manager.ReqSelect(sql, parameters);

            // si on a bien 1 ligne et que la valeur COUNT(*) vaut 1, on renvoie true
            if (records.Count > 0 && Convert.ToInt32(records[0][0]) == 1)
            {
                return true;
            }
            return false;
        }

    }
}