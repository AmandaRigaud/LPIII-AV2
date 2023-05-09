namespace Projeto.APP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            nomeBox = new TextBox();
            gerenteBox = new TextBox();
            resumo = new TextBox();
            dateFim = new DateTimePicker();
            label1 = new Label();
            dateIni = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            status = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(699, 512);
            button1.Name = "button1";
            button1.Size = new Size(114, 41);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCadastrar_Click;
            // 
            // nomeBox
            // 
            nomeBox.Location = new Point(322, 121);
            nomeBox.Margin = new Padding(3, 4, 3, 4);
            nomeBox.Name = "nomeBox";
            nomeBox.Size = new Size(198, 27);
            nomeBox.TabIndex = 1;
            nomeBox.TextChanged += textBox1_TextChanged;
            // 
            // gerenteBox
            // 
            gerenteBox.Location = new Point(322, 176);
            gerenteBox.Margin = new Padding(3, 4, 3, 4);
            gerenteBox.Name = "gerenteBox";
            gerenteBox.Size = new Size(198, 27);
            gerenteBox.TabIndex = 4;
            // 
            // resumo
            // 
            resumo.Location = new Point(322, 439);
            resumo.Margin = new Padding(3, 4, 3, 4);
            resumo.Name = "resumo";
            resumo.Size = new Size(494, 27);
            resumo.TabIndex = 5;
            resumo.TextChanged += textBox5_TextChanged;
            // 
            // dateFim
            // 
            dateFim.Location = new Point(322, 313);
            dateFim.Margin = new Padding(3, 4, 3, 4);
            dateFim.Name = "dateFim";
            dateFim.Size = new Size(228, 27);
            dateFim.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 132);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome do Projeto";
            // 
            // dateIni
            // 
            dateIni.Location = new Point(322, 244);
            dateIni.Margin = new Padding(3, 4, 3, 4);
            dateIni.Name = "dateIni";
            dateIni.Size = new Size(228, 27);
            dateIni.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 180);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 9;
            label2.Text = "Nome do Gerente de Projeto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 255);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 10;
            label3.Text = "Data de Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 324);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 11;
            label4.Text = "Data de Final";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 384);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 12;
            label5.Text = "Status";
            label5.Click += label5_Click;
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "EM ANDAMENTO", "CONCLUIDO", "ABORTADO" });
            status.Location = new Point(322, 373);
            status.Margin = new Padding(3, 4, 3, 4);
            status.Name = "status";
            status.Size = new Size(138, 28);
            status.TabIndex = 13;
            status.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 449);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 14;
            label6.Text = "Resumo do Projeto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(379, 48);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 15;
            label7.Text = "Cadastro de Projeto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(status);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateIni);
            Controls.Add(label1);
            Controls.Add(dateFim);
            Controls.Add(resumo);
            Controls.Add(gerenteBox);
            Controls.Add(nomeBox);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox nomeBox;
        private TextBox gerenteBox;
        private TextBox resumo;
        private DateTimePicker dateFim;
        private Label label1;
        private DateTimePicker dateIni;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox status;
        private Label label6;
        private Label label7;
    }
}