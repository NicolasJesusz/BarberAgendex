namespace AgendaBarber
{
    partial class FrmAgendamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTelefone = new TextBox();
            label3 = new Label();
            dtpData = new DateTimePicker();
            Horario = new Label();
            cmbHora = new ComboBox();
            cmbServico = new ComboBox();
            Serviço = new Label();
            btnAgendar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(282, 63);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 70);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 127);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 2;
            label2.Text = "Telefone:";
            label2.Click += label2_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(282, 120);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(125, 27);
            txtTelefone.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(156, 184);
            label3.Name = "label3";
            label3.Size = new Size(57, 24);
            label3.TabIndex = 4;
            label3.Text = "Data:";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(282, 177);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(250, 27);
            dtpData.TabIndex = 5;
            // 
            // Horario
            // 
            Horario.AutoSize = true;
            Horario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Horario.Location = new Point(156, 239);
            Horario.Name = "Horario";
            Horario.Size = new Size(80, 23);
            Horario.TabIndex = 6;
            Horario.Text = "Horario:";
            // 
            // cmbHora
            // 
            cmbHora.FormattingEnabled = true;
            cmbHora.Location = new Point(282, 239);
            cmbHora.Name = "cmbHora";
            cmbHora.Size = new Size(151, 28);
            cmbHora.TabIndex = 7;
            // 
            // cmbServico
            // 
            cmbServico.FormattingEnabled = true;
            cmbServico.Location = new Point(282, 292);
            cmbServico.Name = "cmbServico";
            cmbServico.Size = new Size(151, 28);
            cmbServico.TabIndex = 8;
            // 
            // Serviço
            // 
            Serviço.AutoSize = true;
            Serviço.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Serviço.Location = new Point(156, 295);
            Serviço.Name = "Serviço";
            Serviço.Size = new Size(81, 23);
            Serviço.TabIndex = 9;
            Serviço.Text = "Serviço:";
            Serviço.Click += label4_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(669, 371);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(94, 29);
            btnAgendar.TabIndex = 10;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.FlatAppearance.BorderSize = 0;

            btnAgendar.BackColor = Color.SteelBlue;
            btnAgendar.ForeColor = Color.White;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(516, 371);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 29);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            btnVoltar .FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 0;

            btnVoltar.BackColor = Color.SteelBlue;
            btnVoltar.ForeColor = Color.White;
            // 
            // FrmAgendamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(823, 495);
            Controls.Add(btnVoltar);
            Controls.Add(btnAgendar);
            Controls.Add(Serviço);
            Controls.Add(cmbServico);
            Controls.Add(cmbHora);
            Controls.Add(Horario);
            Controls.Add(dtpData);
            Controls.Add(label3);
            Controls.Add(txtTelefone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "FrmAgendamento";
            Text = "Form2";
            Load += FrmAgendamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtTelefone;
        private Label label3;
        private DateTimePicker dtpData;
        private Label Horario;
        private ComboBox cmbHora;
        private ComboBox cmbServico;
        private Label Serviço;
        private Button btnAgendar;
        private Button btnVoltar;
    }
}