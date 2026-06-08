namespace AgendaBarber
{
    partial class FrmMainPage
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
            lblTitulo = new Label();
            lblDescricao = new Label();
            btnAgendar = new Button();
            btnAdmin = new Button();
            btnSair = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(276, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BARBEARIA NJ";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(208, 169);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(50, 20);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "label2";
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.SteelBlue;
            btnAgendar.FlatAppearance.BorderSize = 0;
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgendar.ForeColor = Color.White;
            btnAgendar.Location = new Point(81, 76);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(135, 51);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "Novo Agendamento";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.SteelBlue;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(83, 159);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(133, 58);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Página Administrativa";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click_1;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.SteelBlue;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(102, 263);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnAgendar);
            panel1.Controls.Add(btnAdmin);
            panel1.Location = new Point(25, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 344);
            panel1.TabIndex = 5;
            // 
            // FrmMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lblDescricao);
            Controls.Add(lblTitulo);
            Name = "FrmMainPage";
            Text = "FrmMainPage";
            Load += FrmMainPage_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDescricao;
        private Button btnAgendar;
        private Button btnAdmin;
        private Button btnSair;
        private Panel panel1;
    }
}