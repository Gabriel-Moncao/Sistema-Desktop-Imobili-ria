using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaCupece
{
    public partial class CadLocImov1 : Form
    {
        public CadLocImov1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadLocImov2 imovelLoc = new cadLocImov2();
            imovelLoc.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CadLocImov1_Load(object sender, EventArgs e)
        {

        }
    }
}
