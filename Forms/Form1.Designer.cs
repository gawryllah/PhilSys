
namespace fil_sys
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbFilharmonia = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kalendarz = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWydarzenia = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnViewWorkers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vladimir Script", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(350, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 116);
            this.label1.TabIndex = 0;
            this.label1.Text = "FilSys";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 110);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbFilharmonia
            // 
            this.lbFilharmonia.FormattingEnabled = true;
            this.lbFilharmonia.ItemHeight = 15;
            this.lbFilharmonia.Location = new System.Drawing.Point(61, 215);
            this.lbFilharmonia.Name = "lbFilharmonia";
            this.lbFilharmonia.Size = new System.Drawing.Size(87, 139);
            this.lbFilharmonia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wybierz filharmonie";
            // 
            // kalendarz
            // 
            this.kalendarz.Location = new System.Drawing.Point(186, 215);
            this.kalendarz.Name = "kalendarz";
            this.kalendarz.TabIndex = 4;
            this.kalendarz.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.kalendarz_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wybierz date ktora cie interesuje";
            // 
            // lbWydarzenia
            // 
            this.lbWydarzenia.FormattingEnabled = true;
            this.lbWydarzenia.ItemHeight = 15;
            this.lbWydarzenia.Items.AddRange(new object[] {
            "Wydarzenie1",
            "Wydarzenie2",
            "Wydarzenie3",
            "Wydarzenie4",
            "Wydarzenie5",
            "Wydarzenie6",
            "Wydarzenie7",
            "Wydarzenie8",
            "Wydarzenie9",
            "Wydarzenie10"});
            this.lbWydarzenia.Location = new System.Drawing.Point(472, 229);
            this.lbWydarzenia.Name = "lbWydarzenia";
            this.lbWydarzenia.Size = new System.Drawing.Size(209, 109);
            this.lbWydarzenia.TabIndex = 6;
            this.lbWydarzenia.SelectedIndexChanged += new System.EventHandler(this.lbWydarzenia_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wydarzenia w danym dniu:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(627, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 15);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Zarejestruj sie";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(712, 35);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(64, 15);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Zaloguj sie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dodaj pracownika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewWorkers
            // 
            this.btnViewWorkers.Location = new System.Drawing.Point(657, 356);
            this.btnViewWorkers.Name = "btnViewWorkers";
            this.btnViewWorkers.Size = new System.Drawing.Size(109, 38);
            this.btnViewWorkers.TabIndex = 11;
            this.btnViewWorkers.Text = "Zobacz pracowników";
            this.btnViewWorkers.UseVisualStyleBackColor = true;
            this.btnViewWorkers.Click += new System.EventHandler(this.btnViewWorkers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewWorkers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbWydarzenia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kalendarz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFilharmonia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main panel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbFilharmonia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar kalendarz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbWydarzenia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnViewWorkers;
    }
}

