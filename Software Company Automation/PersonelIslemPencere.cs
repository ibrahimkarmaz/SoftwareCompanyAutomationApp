using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Company_Automation
{
    public partial class PersonelIslemPencere : Form
    {
        public PersonelIslemPencere()
        {
            InitializeComponent();
        }

        private void musteriIslemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriAnaPencere MusteriIslem = new MusteriAnaPencere();
            MusteriIslem.ShowDialog();
            
        }
    }
}
