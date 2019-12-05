namespace WindowsForms_1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.etykieta1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etykieta1
            // 
            this.etykieta1.AutoSize = true;
            this.etykieta1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etykieta1.Location = new System.Drawing.Point(646, 43);
            this.etykieta1.Name = "etykieta1";
            this.etykieta1.Size = new System.Drawing.Size(41, 28);
            this.etykieta1.TabIndex = 0;
            this.etykieta1.Text = "elo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(243, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "elo";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(361, 175);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(363, 20);
            this.text1.TabIndex = 2;
            this.text1.Text = "xdddd";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 99);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.etykieta1);
            this.Name = "Form1";
            this.Text = "Pierwszy program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etykieta1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button button1;
    }
}

