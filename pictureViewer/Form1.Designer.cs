namespace pictureViewer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MostrarBotao = new System.Windows.Forms.Button();
            this.LimparBotao = new System.Windows.Forms.Button();
            this.FundoBotao = new System.Windows.Forms.Button();
            this.FecharBotao = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1230, 509);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1224, 452);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 461);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Stretch";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.MostrarBotao);
            this.flowLayoutPanel1.Controls.Add(this.LimparBotao);
            this.flowLayoutPanel1.Controls.Add(this.FundoBotao);
            this.flowLayoutPanel1.Controls.Add(this.FecharBotao);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(187, 461);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1040, 45);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // MostrarBotao
            // 
            this.MostrarBotao.AutoSize = true;
            this.MostrarBotao.Location = new System.Drawing.Point(894, 3);
            this.MostrarBotao.Name = "MostrarBotao";
            this.MostrarBotao.Size = new System.Drawing.Size(143, 26);
            this.MostrarBotao.TabIndex = 0;
            this.MostrarBotao.Text = "Mostrar uma imagem";
            this.MostrarBotao.UseVisualStyleBackColor = true;
            this.MostrarBotao.Click += new System.EventHandler(this.MostrarBotao_Click);
            // 
            // LimparBotao
            // 
            this.LimparBotao.AutoSize = true;
            this.LimparBotao.Location = new System.Drawing.Point(767, 3);
            this.LimparBotao.Name = "LimparBotao";
            this.LimparBotao.Size = new System.Drawing.Size(121, 26);
            this.LimparBotao.TabIndex = 1;
            this.LimparBotao.Text = "Limpar a imagem";
            this.LimparBotao.UseVisualStyleBackColor = true;
            this.LimparBotao.Click += new System.EventHandler(this.button2_Click);
            // 
            // FundoBotao
            // 
            this.FundoBotao.AutoSize = true;
            this.FundoBotao.Location = new System.Drawing.Point(574, 3);
            this.FundoBotao.Name = "FundoBotao";
            this.FundoBotao.Size = new System.Drawing.Size(187, 26);
            this.FundoBotao.TabIndex = 2;
            this.FundoBotao.Text = "Definir a cor da tela de fundo";
            this.FundoBotao.UseVisualStyleBackColor = true;
            this.FundoBotao.Click += new System.EventHandler(this.FundoBotao_Click);
            // 
            // FecharBotao
            // 
            this.FecharBotao.AutoSize = true;
            this.FecharBotao.Location = new System.Drawing.Point(493, 3);
            this.FecharBotao.Name = "FecharBotao";
            this.FecharBotao.Size = new System.Drawing.Size(75, 26);
            this.FecharBotao.TabIndex = 3;
            this.FecharBotao.Text = "Fechar";
            this.FecharBotao.UseVisualStyleBackColor = true;
            this.FecharBotao.Click += new System.EventHandler(this.FecharBotao_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Selecionar um arquivo de imagem";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Visualizador de Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button MostrarBotao;
        private System.Windows.Forms.Button LimparBotao;
        private System.Windows.Forms.Button FundoBotao;
        private System.Windows.Forms.Button FecharBotao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

