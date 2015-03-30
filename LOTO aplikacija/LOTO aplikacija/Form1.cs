using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOTO_aplikacija
{
    public partial class FrmLoto : Form
    {
        public FrmLoto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loto l = new Loto();
            l.izbacivanjeBrojeva(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loto k = new Loto();
            k.provjeraDobitka(this);
        }
    }
}
