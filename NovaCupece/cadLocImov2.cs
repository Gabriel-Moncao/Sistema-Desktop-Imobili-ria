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
    public partial class cadLocImov2 : Form
    {
        public cadLocImov2()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void cadLocImov2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadLocImov3 fimCad = new CadLocImov3();
            fimCad.Visible = true;
            this.Dispose();
        }
    }
}
