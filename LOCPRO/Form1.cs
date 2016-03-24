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
using System.Data;

namespace LOCPRO
{
   
        

    public partial class Form1 : Form
    {
        MdiClient ctlMDI;
        private MySqlConnection myConnection;
        private bool connopen = false;
        private bool errgrave = false;
        private bool chargement = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void co_click(object sender, EventArgs e)
        {
            
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
                Controleur.init();
                Controleur.Vmodele.seconnecter();
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Controleur.Vmodele.seconnecter();
            MessageBox.Show("oui", "oui", MessageBoxButtons.OK);
        }
     
    }
}
