namespace ProyectoAxel
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
            this.btnDrake = new System.Windows.Forms.Button();
            this.btnBugs = new System.Windows.Forms.Button();
            this.btnBart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOmitir = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDrake
            // 
            this.btnDrake.Location = new System.Drawing.Point(82, 155);
            this.btnDrake.Name = "btnDrake";
            this.btnDrake.Size = new System.Drawing.Size(337, 32);
            this.btnDrake.TabIndex = 0;
            this.btnDrake.Text = "Drake Parker";
            this.btnDrake.UseVisualStyleBackColor = true;
            this.btnDrake.Click += new System.EventHandler(this.btnDrake_Click);
            // 
            // btnBugs
            // 
            this.btnBugs.Location = new System.Drawing.Point(82, 117);
            this.btnBugs.Name = "btnBugs";
            this.btnBugs.Size = new System.Drawing.Size(337, 32);
            this.btnBugs.TabIndex = 1;
            this.btnBugs.Text = "Bugs Bunny";
            this.btnBugs.UseVisualStyleBackColor = true;
            this.btnBugs.Click += new System.EventHandler(this.MiMetodo_Clic);
            // 
            // btnBart
            // 
            this.btnBart.Location = new System.Drawing.Point(82, 193);
            this.btnBart.Name = "btnBart";
            this.btnBart.Size = new System.Drawing.Size(337, 32);
            this.btnBart.TabIndex = 2;
            this.btnBart.Text = "Bart Simpson";
            this.btnBart.UseVisualStyleBackColor = true;
            this.btnBart.Click += new System.EventHandler(this.btnBart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(82, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 62);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "¿Quién dijo la frase \"oye, tranquilo viejo\"?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOmitir
            // 
            this.btnOmitir.Location = new System.Drawing.Point(358, 231);
            this.btnOmitir.Name = "btnOmitir";
            this.btnOmitir.Size = new System.Drawing.Size(61, 25);
            this.btnOmitir.TabIndex = 4;
            this.btnOmitir.Text = "OMITIR";
            this.btnOmitir.UseVisualStyleBackColor = true;
            this.btnOmitir.Click += new System.EventHandler(this.btnOmitir_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(319, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "PUNTOS:";
            // 
            // lblPuntos
            // 
            this.lblPuntos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuntos.Location = new System.Drawing.Point(380, 25);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPuntos.Size = new System.Drawing.Size(39, 20);
            this.lblPuntos.TabIndex = 6;
            this.lblPuntos.Text = " ";
            this.lblPuntos.Click += new System.EventHandler(this.lblPuntos_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(480, 283);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnOmitir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBart);
            this.Controls.Add(this.btnBugs);
            this.Controls.Add(this.btnDrake);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrake;
        private System.Windows.Forms.Button btnBugs;
        private System.Windows.Forms.Button btnBart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOmitir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPuntos;
    }
}