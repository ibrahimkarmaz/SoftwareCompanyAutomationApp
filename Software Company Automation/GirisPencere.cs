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
    public partial class GirisPencere : Form
    {
        public GirisPencere()
        {
            InitializeComponent();
        }
        public static string global_baglanti_adresi = @"server=DESKTOP-5DGSRBQ;database=SCA;Trusted_Connection=yes";
        private void GirisPencere_Load(object sender, EventArgs e)
        {

        }
    }
}
