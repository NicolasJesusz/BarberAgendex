using System;
using System.Windows.Forms;

namespace AgendaBarber
{
    public partial class FrmMainPage : Form
    {
        public FrmMainPage()
        {
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            FrmAgendamento frm = new FrmAgendamento();
            frm.Show();
            this.Hide();
        }




        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();

        }

        private void FrmMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}