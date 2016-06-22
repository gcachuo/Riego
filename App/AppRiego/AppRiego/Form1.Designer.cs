namespace AppRiego
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHoraRegado = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.NumericUpDown();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnRegadoManual = new System.Windows.Forms.Button();
            this.txtPuerto = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Final Sustentabilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora de riego:";
            // 
            // dtpHoraRegado
            // 
            this.dtpHoraRegado.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraRegado.Location = new System.Drawing.Point(17, 137);
            this.dtpHoraRegado.Name = "dtpHoraRegado";
            this.dtpHoraRegado.Size = new System.Drawing.Size(214, 20);
            this.dtpHoraRegado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Duración de regado:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(17, 191);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(214, 20);
            this.txtDuracion.TabIndex = 4;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(17, 217);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(208, 46);
            this.btnConfigurar.TabIndex = 5;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnRegadoManual
            // 
            this.btnRegadoManual.Enabled = false;
            this.btnRegadoManual.Location = new System.Drawing.Point(17, 301);
            this.btnRegadoManual.Name = "btnRegadoManual";
            this.btnRegadoManual.Size = new System.Drawing.Size(208, 50);
            this.btnRegadoManual.TabIndex = 6;
            this.btnRegadoManual.Text = "Iniciar regado manual";
            this.btnRegadoManual.UseVisualStyleBackColor = true;
            this.btnRegadoManual.Click += new System.EventHandler(this.btnRegadoManual_Click);
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(17, 66);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(120, 20);
            this.txtPuerto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Puerto serial:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(144, 64);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(87, 23);
            this.btnConectar.TabIndex = 9;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 376);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.btnRegadoManual);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpHoraRegado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "App Riego";
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuerto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHoraRegado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtDuracion;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnRegadoManual;
        private System.Windows.Forms.NumericUpDown txtPuerto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConectar;
    }
}

