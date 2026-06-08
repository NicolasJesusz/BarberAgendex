using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgendaBarber
{
    public partial class FrmAdmin : Form
    {
        private string conexao =
    @"Server=(localdb)\MSSQLLocalDB;
      Database=BarbeariaDB;
      Trusted_Connection=True;
      TrustServerCertificate=True;";
        public FrmAdmin()
        {
            InitializeComponent();
        }
        private void CarregarAgendamentos()
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                string sql = @"
            SELECT
                Id,
                NomeCliente,
                Telefone,
                DataAgendamento,
                HoraAgendamento,
                Servico
            FROM Agendamentos
            ORDER BY DataAgendamento, HoraAgendamento";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvAgendamentos.DataSource = dt;
            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            CarregarAgendamentos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarAgendamentos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAgendamentos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um agendamento.");
                return;
            }

            int id = Convert.ToInt32(
                dgvAgendamentos.CurrentRow.Cells["Id"].Value);

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                string sql =
                    "DELETE FROM Agendamentos WHERE Id = @id";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Agendamento excluído!");

            CarregarAgendamentos();
        }
    }
}

