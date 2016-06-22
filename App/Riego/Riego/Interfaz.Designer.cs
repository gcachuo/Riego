namespace Riego
{
    partial class Interfaz
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
            this.numPuerto = new System.Windows.Forms.NumericUpDown();
            this.btnConectar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnClima = new System.Windows.Forms.Button();
            this.dtpHoraRegado = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValores = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPuerto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numPuerto
            // 
            this.numPuerto.Location = new System.Drawing.Point(13, 13);
            this.numPuerto.Name = "numPuerto";
            this.numPuerto.Size = new System.Drawing.Size(50, 20);
            this.numPuerto.TabIndex = 0;
            this.numPuerto.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(84, 13);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(120, 23);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(129, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnClima
            // 
            this.btnClima.Location = new System.Drawing.Point(16, 147);
            this.btnClima.Name = "btnClima";
            this.btnClima.Size = new System.Drawing.Size(191, 23);
            this.btnClima.TabIndex = 6;
            this.btnClima.Text = "Obtener Clima Manualmente";
            this.btnClima.UseVisualStyleBackColor = true;
            this.btnClima.Click += new System.EventHandler(this.btnClima_Click);
            // 
            // dtpHoraRegado
            // 
            this.dtpHoraRegado.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraRegado.Location = new System.Drawing.Point(112, 193);
            this.dtpHoraRegado.Name = "dtpHoraRegado";
            this.dtpHoraRegado.Size = new System.Drawing.Size(89, 20);
            this.dtpHoraRegado.TabIndex = 7;
            this.dtpHoraRegado.Value = new System.DateTime(2016, 6, 21, 14, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valores del Clima:";
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Location = new System.Drawing.Point(111, 279);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(88, 13);
            this.lblValores.TabIndex = 9;
            this.lblValores.Text = "                           ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(112, 224);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hora de Encendido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tiempo de Regado:";
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblValores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHoraRegado);
            this.Controls.Add(this.btnClima);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.numPuerto);
            this.Name = "Interfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPuerto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPuerto;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnClima;
        private System.Windows.Forms.DateTimePicker dtpHoraRegado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValores;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}