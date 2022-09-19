
namespace fil_sys
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
            this.tbPensja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRodzaj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInstrument = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPensja
            // 
            this.tbPensja.Location = new System.Drawing.Point(237, 61);
            this.tbPensja.Name = "tbPensja";
            this.tbPensja.Size = new System.Drawing.Size(100, 23);
            this.tbPensja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(164, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pensja";
            // 
            // tbRodzaj
            // 
            this.tbRodzaj.Location = new System.Drawing.Point(237, 99);
            this.tbRodzaj.Name = "tbRodzaj";
            this.tbRodzaj.Size = new System.Drawing.Size(100, 23);
            this.tbRodzaj.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(164, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rodzaj";
            // 
            // tbInstrument
            // 
            this.tbInstrument.Location = new System.Drawing.Point(237, 139);
            this.tbInstrument.Name = "tbInstrument";
            this.tbInstrument.Size = new System.Drawing.Size(100, 23);
            this.tbInstrument.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(135, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Instrument";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDodaj.Location = new System.Drawing.Point(188, 207);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(103, 42);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInstrument);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRodzaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPensja);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj muzyka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPensja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRodzaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInstrument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
    }
}