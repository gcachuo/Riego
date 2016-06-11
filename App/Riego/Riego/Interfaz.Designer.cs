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
            ((System.ComponentModel.ISupportInitialize)(this.numPuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // numPuerto
            // 
            this.numPuerto.Location = new System.Drawing.Point(13, 13);
            this.numPuerto.Name = "numPuerto";
            this.numPuerto.Size = new System.Drawing.Size(50, 20);
            this.numPuerto.TabIndex = 0;
            this.numPuerto.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(84, 13);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.numPuerto);
            this.Name = "Interfaz";
            this.Text = "Interfaz";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPuerto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPuerto;
        private System.Windows.Forms.Button btnConectar;
    }
}