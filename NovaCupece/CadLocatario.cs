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
    public partial class CadLocatario : Form
    {
        public CadLocatario()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadLocatario2 locatario2 = new CadLocatario2();
            locatario2.Visible = true;
            this.Dispose();
        }
    }
}
