namespace ProyectoAxel
{
    partial class Form3
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
            this.btnOmitir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTiro = new System.Windows.Forms.Button();
            this.btnGary = new System.Windows.Forms.Button();
            this.btnPatricio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOmitir
            // 
            this.btnOmitir.Location = new System.Drawing.Point(359, 232);
            this.btnOmitir.Name = "btnOmitir";
            this.btnOmitir.Size = new System.Drawing.Size(61, 25);
            this.btnOmitir.TabIndex = 9;
            this.btnOmitir.Text = "OMITIR";
            this.btnOmitir.UseVisualStyleBackColor = true;
            this.btnOmitir.Click += new System.EventHandler(this.btnOmitir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(83, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 62);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "¿Cómo se llama la mascota principal de Bob Esponja?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTiro
            // 
            this.btnTiro.Location = new System.Drawing.Point(83, 194);
            this.btnTiro.Name = "btnTiro";
            this.btnTiro.Size = new System.Drawing.Size(337, 32);
            this.btnTiro.TabIndex = 7;
            this.btnTiro.Text = "Tiro al Blanco";
            this.btnTiro.UseVisualStyleBackColor = true;
            this.btnTiro.Click += new System.EventHandler(this.btnTiro_Click);
            // 
            // btnGary
            // 
            this.btnGary.Location = new System.Drawing.Point(83, 118);
            this.btnGary.Name = "btnGary";
            this.btnGary.Size = new System.Drawing.Size(337, 32);
            this.btnGary.TabIndex = 6;
            this.btnGary.Text = "Gary";
            this.btnGary.UseVisualStyleBackColor = true;
            this.btnGary.Click += new System.EventHandler(this.btnGary_Click);
            // 
            // btnPatricio
            // 
            this.btnPatricio.Location = new System.Drawing.Point(83, 156);
            this.btnPatricio.Name = "btnPatricio";
            this.btnPatricio.Size = new System.Drawing.Size(337, 32);
            this.btnPatricio.TabIndex = 5;
            this.btnPatricio.Text = "Patricio";
            this.btnPatricio.UseVisualStyleBackColor = true;
            this.btnPatricio.Click += new System.EventHandler(this.btnPatricio_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 283);
            this.Controls.Add(this.btnOmitir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTiro);
            this.Controls.Add(this.btnGary);
            this.Controls.Add(this.btnPatricio);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOmitir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTiro;
        private System.Windows.Forms.Button btnGary;
        private System.Windows.Forms.Button btnPatricio;
    }
}