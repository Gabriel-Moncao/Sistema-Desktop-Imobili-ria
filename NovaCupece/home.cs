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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void visualizarTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadFunc cadFunc = new CadFunc();
            cadFunc.Visible = true;
        }

        private void atendimenttosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atendimento atendimento = new Atendimento();
            atendimento.Visible = true;
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadLocImov1 locador = new CadLocImov1();
            locador.Visible = true;
        }

        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
