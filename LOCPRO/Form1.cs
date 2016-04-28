using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace LOCPRO
{
   
        
   
    public partial class Form1 : Form
    {
        MdiClient ctlMDI;
        private DataTable id= new DataTable();
        private DataTable mdp= new DataTable();
        private string a="";
        private List<string> listid=new List<string>();
        private List<string> listmdp=new List<string>();
        public int index;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void co_click(object sender, EventArgs e)
        {
            if (verfiertech() == true)
            {
                MessageBox.Show("Vous avez réussi à vous connecter");
                Form2 bli = new Form2();
                this.Hide();
                bli.Show();

            }
            else
            {
                MessageBox.Show("Mauvais identifiant ou mot de passe","Erreur");
            }
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                }
            }
            Controleur.init();
            Controleur.Vmodele.seconnecter();
            id=Controleur.Vmodele.requete("SELECT IDTECH from technicien");
            mdp = Controleur.Vmodele.requete("SELECT MDPTECH from technicien");
            foreach (DataRow row in id.Rows)
            {
                foreach (DataColumn column in id.Columns)
                {
                    a = a + row[column];
                    listid.Add(a);
                    a = "";
                }
            }
            foreach (DataRow row in mdp.Rows)
            {
                foreach (DataColumn column in mdp.Columns)
                {
                    a = a + row[column];
                    listmdp.Add(a);
                    a = "";
                }
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controleur.Vmodele.seconnecter();
            MessageBox.Show("oui", "oui", MessageBoxButtons.OK);
        }

        private bool verfiertech(){
            int i=0;
            bool oui = false;
            while(i<listmdp.Count && oui==false) {
                if (listid[i]==textBox1.Text && listmdp[i]==textBox2.Text)
                {
                    oui=true;
                    index = i;
                }
                i = i + 1;                 
            }
            return oui;

            }
        }
}
