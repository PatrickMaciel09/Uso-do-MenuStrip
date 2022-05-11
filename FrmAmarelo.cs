using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class FrmAmarelo : Form
    {
        public FrmAmarelo()
        {
            InitializeComponent();
        }

        private void exibirFormAmarelo_Click(object sender, EventArgs e)
        {
            FrmAmarelo frm = new FrmAmarelo(); // indico qual form sera aberto
            this.Hide(); // fechar o atual
            frm.ShowDialog();
        }

        private void exibirFormAzul_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul(); // indico qual form sera aberto
            this.Hide(); // fechar o atual
            frm.ShowDialog();
        }

        private void exibirFormVerde_Click(object sender, EventArgs e)
        {
            FrmVerde frm = new FrmVerde(); // indico qual form sera aberto
            this.Hide(); // fechar o atual
            frm.ShowDialog();
        }
    }
}
