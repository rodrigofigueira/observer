namespace ForecastWeatherUI
{
    partial class FrmMain
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
            this.BtnGetWeatherData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTempAtual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTempMinima = new System.Windows.Forms.TextBox();
            this.TxtTemMaxima = new System.Windows.Forms.TextBox();
            this.TxtSensacaoTermica = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtVelocidadeVento = new System.Windows.Forms.TextBox();
            this.TxtGrausVento = new System.Windows.Forms.TextBox();
            this.TxtRajadasVento = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGetWeatherData
            // 
            this.BtnGetWeatherData.Location = new System.Drawing.Point(12, 12);
            this.BtnGetWeatherData.Name = "BtnGetWeatherData";
            this.BtnGetWeatherData.Size = new System.Drawing.Size(525, 66);
            this.BtnGetWeatherData.TabIndex = 0;
            this.BtnGetWeatherData.Text = "Obter Dados do Tempo de Suzano";
            this.BtnGetWeatherData.UseVisualStyleBackColor = true;
            this.BtnGetWeatherData.Click += new System.EventHandler(this.BtnGetWeatherData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSensacaoTermica);
            this.groupBox1.Controls.Add(this.TxtTemMaxima);
            this.groupBox1.Controls.Add(this.TxtTempMinima);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtTempAtual);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da temperatura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temp. Atual";
            // 
            // TxtTempAtual
            // 
            this.TxtTempAtual.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTempAtual.Location = new System.Drawing.Point(137, 24);
            this.TxtTempAtual.Name = "TxtTempAtual";
            this.TxtTempAtual.ReadOnly = true;
            this.TxtTempAtual.Size = new System.Drawing.Size(100, 23);
            this.TxtTempAtual.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temp. Mínima";            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temp. Máxima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sensação Térmica";
            // 
            // TxtTempMinima
            // 
            this.TxtTempMinima.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTempMinima.Location = new System.Drawing.Point(137, 53);
            this.TxtTempMinima.Name = "TxtTempMinima";
            this.TxtTempMinima.ReadOnly = true;
            this.TxtTempMinima.Size = new System.Drawing.Size(100, 23);
            this.TxtTempMinima.TabIndex = 5;
            // 
            // TxtTemMaxima
            // 
            this.TxtTemMaxima.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTemMaxima.Location = new System.Drawing.Point(137, 84);
            this.TxtTemMaxima.Name = "TxtTemMaxima";
            this.TxtTemMaxima.ReadOnly = true;
            this.TxtTemMaxima.Size = new System.Drawing.Size(100, 23);
            this.TxtTemMaxima.TabIndex = 6;
            // 
            // TxtSensacaoTermica
            // 
            this.TxtSensacaoTermica.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSensacaoTermica.Location = new System.Drawing.Point(137, 115);
            this.TxtSensacaoTermica.Name = "TxtSensacaoTermica";
            this.TxtSensacaoTermica.ReadOnly = true;
            this.TxtSensacaoTermica.Size = new System.Drawing.Size(100, 23);
            this.TxtSensacaoTermica.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtRajadasVento);
            this.groupBox2.Controls.Add(this.TxtGrausVento);
            this.groupBox2.Controls.Add(this.TxtVelocidadeVento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(294, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Vento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Velocidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Graus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Rajadas";
            // 
            // TxtVelocidadeVento
            // 
            this.TxtVelocidadeVento.Location = new System.Drawing.Point(116, 29);
            this.TxtVelocidadeVento.Name = "TxtVelocidadeVento";
            this.TxtVelocidadeVento.Size = new System.Drawing.Size(100, 23);
            this.TxtVelocidadeVento.TabIndex = 3;
            // 
            // TxtGrausVento
            // 
            this.TxtGrausVento.Location = new System.Drawing.Point(116, 58);
            this.TxtGrausVento.Name = "TxtGrausVento";
            this.TxtGrausVento.Size = new System.Drawing.Size(100, 23);
            this.TxtGrausVento.TabIndex = 4;
            // 
            // TxtRajadasVento
            // 
            this.TxtRajadasVento.Location = new System.Drawing.Point(116, 87);
            this.TxtRajadasVento.Name = "TxtRajadasVento";
            this.TxtRajadasVento.Size = new System.Drawing.Size(100, 23);
            this.TxtRajadasVento.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 260);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnGetWeatherData);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forecast Weather";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnGetWeatherData;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox TxtTempAtual;
        private Label label1;
        private TextBox TxtSensacaoTermica;
        private TextBox TxtTemMaxima;
        private TextBox TxtTempMinima;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox TxtRajadasVento;
        private TextBox TxtGrausVento;
        private TextBox TxtVelocidadeVento;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}