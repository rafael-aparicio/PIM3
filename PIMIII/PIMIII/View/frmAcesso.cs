using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace PIMIII
{
    public partial class frmMain : Form
    {
        Thread tela;

        public frmMain()
        {
            InitializeComponent();
        }


        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario();
            usuario.Show();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnTranferir_Click(object sender, EventArgs e)
        {
            this.Close();
            tela = new Thread(abrijanela);
            tela.SetApartmentState(ApartmentState.STA);
            tela.Start();
        }

        public void abrijanela(object obj)
        {
            Application.Run(new frmMenu());
        }
    
    }
}
