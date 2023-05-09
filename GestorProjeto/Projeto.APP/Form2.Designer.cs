namespace Projeto.APP
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button2 = new Button();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            projetoRepositoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)projetoRepositoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(623, 409);
            button1.Name = "button1";
            button1.Size = new Size(146, 29);
            button1.TabIndex = 1;
            button1.Text = "Cadastrar projeto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button2
            // 
            button2.Location = new Point(675, 10);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Location = new Point(344, 14);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "PROJETOS";
            // 
            // button4
            // 
            button4.Location = new Point(33, 198);
            button4.Name = "button4";
            button4.Size = new Size(39, 29);
            button4.TabIndex = 6;
            button4.Text = "<=";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(730, 198);
            button3.Name = "button3";
            button3.Size = new Size(39, 29);
            button3.TabIndex = 7;
            button3.Text = "=>";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Location = new Point(190, 65);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 8;
            label1.Text = "nomeP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Location = new Point(190, 112);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "gerente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Location = new Point(190, 207);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 11;
            label5.Text = "Resumo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AliceBlue;
            label6.Location = new Point(489, 309);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 12;
            label6.Text = "Data Fim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AliceBlue;
            label7.Location = new Point(190, 309);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 13;
            label7.Text = "Data Inicio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AliceBlue;
            label8.Location = new Point(306, 309);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 14;
            label8.Text = "Data Inicio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.AliceBlue;
            label9.Location = new Point(592, 309);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 15;
            label9.Text = "Data Fim";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "EM ANDAMENTO", "CONCLUIDO", "ABORTADO" });
            comboBox1.Location = new Point(190, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "Status";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // projetoRepositoryBindingSource
            // 
            projetoRepositoryBindingSource.DataSource = typeof(BLL.ProjetoRepository);
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)projetoRepositoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button2;
        private Label label2;
        private Button button4;
        private Button button3;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private BindingSource projetoRepositoryBindingSource;
    }
}