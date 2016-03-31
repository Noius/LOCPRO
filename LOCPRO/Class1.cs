using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace LOCPRO
{
    public class Modele
    {
        private MySqlConnection myConnection;
        private bool connopen = false;
        private bool errgrave = false;
        private bool chargement = false;
        private MySqlDataAdapter dA1 = new MySqlDataAdapter();
        private DataTable dT1 = new DataTable();
        public Modele()
        {
        }
        public bool Connopen
        {
            get { return connopen; }
            set { connopen = value; }
        }
        public bool Errgrave
        {
            get { return errgrave; }
            set { errgrave = value; }
        }
        public bool Chargement
        {
            get { return chargement; }
            set { chargement = value; }
        }
        public DataTable DT1
        {
            get { return dT1; }
            set { dT1 = value; }
        }
        public void seconnecter()
        {

            string myConnectionString = "Database=bdd_loc;Data Source=localhost;User Id=root;";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative
            {
                myConnection.Open();
                MessageBox.Show("Connexion réussie");
                connopen = true;
                
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                connopen = false; errgrave = true;
            }

        }
        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        public DataTable requete(string larequete)
        {
            
            dA1.SelectCommand = new MySqlCommand(larequete, myConnection);
            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(dA1);
            try
            {
                dT1.Clear();
                dA1.Fill(dT1);
                chargement = true;
                return dT1; 
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "PBS table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
                return dT1;
            }
        }
    }
}
