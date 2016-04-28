using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOCPRO
{
    public partial class Form2 : Form
    {
        private DataTable description;
        private string a;
        private List<string> listdescription=new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            description=Controleur.Vmodele.requete("SELECT * FROM ticket");
           
            foreach (DataRow row in description.Rows)
            {

                foreach (DataColumn column in description.Columns)
                {
                    richTextBox1.Text = richTextBox1.Text + row[column]+", ";
                    
                }
                richTextBox1.Text = richTextBox1.Text +  "\n";
                
            }
 
        }
    }
}
