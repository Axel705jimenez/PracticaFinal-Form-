namespace ProyectoAxel
{
    partial class Form4
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
            this.btnGoku = new System.Windows.Forms.Button();
            this.btnVegetta = new System.Windows.Forms.Button();
            this.btnPicollo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOmitir
            // 
            this.btnOmitir.Location = new System.Drawing.Point(359, 233);
            this.btnOmitir.Name = "btnOmitir";
            this.btnOmitir.Size = new System.Drawing.Size(61, 25);
            this.btnOmitir.TabIndex = 14;
            this.btnOmitir.Text = "OMITIR";
            this.btnOmitir.UseVisualStyleBackColor = true;
            this.btnOmitir.Click += new System.EventHandler(this.btnOmitir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(83, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 62);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "¿Cómo se llama el personaje principal de Dragon Ball? ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGoku
            // 
            this.btnGoku.Location = new System.Drawing.Point(83, 195);
            this.btnGoku.Name = "btnGoku";
            this.btnGoku.Size = new System.Drawing.Size(337, 32);
            this.btnGoku.TabIndex = 12;
            this.btnGoku.Text = "Goku";
            this.btnGoku.UseVisualStyleBackColor = true;
            this.btnGoku.Click += new System.EventHandler(this.btnGoku_Click);
            // 
            // btnVegetta
            // 
            this.btnVegetta.Location = new System.Drawing.Point(83, 119);
            this.btnVegetta.Name = "btnVegetta";
            this.btnVegetta.Size = new System.Drawing.Size(337, 32);
            this.btnVegetta.TabIndex = 11;
            this.btnVegetta.Text = "Vegetta";
            this.btnVegetta.UseVisualStyleBackColor = true;
            this.btnVegetta.Click += new System.EventHandler(this.btnVegetta_Click);
            // 
            // btnPicollo
            // 
            this.btnPicollo.Location = new System.Drawing.Point(83, 157);
            this.btnPicollo.Name = "btnPicollo";
            this.btnPicollo.Size = new System.Drawing.Size(337, 32);
            this.btnPicollo.TabIndex = 10;
            this.btnPicollo.Text = "Picollo";
            this.btnPicollo.UseVisualStyleBackColor = true;
            this.btnPicollo.Click += new System.EventHandler(this.btnPicollo_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 283);
            this.Controls.Add(this.btnOmitir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGoku);
            this.Controls.Add(this.btnVegetta);
            this.Controls.Add(this.btnPicollo);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOmitir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGoku;
        private System.Windows.Forms.Button btnVegetta;
        private System.Windows.Forms.Button btnPicollo;
    }
}