using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgendaBarber
{
    public partial class FrmAgendamento : Form
    {
        public FrmAgendamento()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void FrmAgendamento_Load(object sender, EventArgs e)
        {
            cmbHora.Items.Add("09:00");
            cmbHora.Items.Add("10:00");
            cmbHora.Items.Add("11:00");
            cmbHora.Items.Add("12:00");
            cmbHora.Items.Add("13:00");
            cmbHora.Items.Add("14:00");
            cmbHora.Items.Add("15:00");
            cmbHora.Items.Add("16:00");
            cmbHora.Items.Add("17:00");

            cmbServico.Items.Add("Corte");
            cmbServico.Items.Add("Barba");
            cmbServico.Items.Add("Corte + Barba");
            cmbServico.Items.Add("Pigmentação");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string conexao =
                @"Server=(localdb)\MSSQLLocalDB;
          Database=BarbeariaDB;
          Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                string sql = @"INSERT INTO Agendamentos
                       (NomeCliente, Telefone,
                        DataAgendamento,
                        HoraAgendamento,
                        Servico)
                       VALUES
                       (@nome,@telefone,@data,@hora,@servico)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@data", dtpData.Value.Date);
                    cmd.Parameters.AddWithValue("@hora", cmbHora.Text);
                    cmd.Parameters.AddWithValue("@servico", cmbServico.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Agendamento salvo com sucesso!");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmMainPage frm = new FrmMainPage();
            frm.Show();
            this.Close();
        }
    }


}



