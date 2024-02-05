
namespace SzpitalGUI
{
    partial class WidokGlowny
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WidokGlowny));
            this.lvPracownicy = new System.Windows.Forms.ListView();
            this.imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stanowisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specjalnosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnWyloguj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDyzury = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvPracownicy
            // 
            this.lvPracownicy.BackColor = System.Drawing.Color.White;
            this.lvPracownicy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.imie,
            this.nazwisko,
            this.stanowisko,
            this.specjalnosc});
            this.lvPracownicy.Font = new System.Drawing.Font("Rockwell", 15.25F);
            this.lvPracownicy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.lvPracownicy.FullRowSelect = true;
            this.lvPracownicy.HideSelection = false;
            this.lvPracownicy.Location = new System.Drawing.Point(20, 37);
            this.lvPracownicy.Margin = new System.Windows.Forms.Padding(2);
            this.lvPracownicy.MultiSelect = false;
            this.lvPracownicy.Name = "lvPracownicy";
            this.lvPracownicy.Size = new System.Drawing.Size(770, 409);
            this.lvPracownicy.TabIndex = 0;
            this.lvPracownicy.UseCompatibleStateImageBehavior = false;
            this.lvPracownicy.View = System.Windows.Forms.View.Details;
            // 
            // imie
            // 
            this.imie.Text = "Imię";
            this.imie.Width = 120;
            // 
            // nazwisko
            // 
            this.nazwisko.Text = "Nazwisko";
            this.nazwisko.Width = 120;
            // 
            // stanowisko
            // 
            this.stanowisko.Text = "Stanowisko";
            this.stanowisko.Width = 120;
            // 
            // specjalnosc
            // 
            this.specjalnosc.Text = "Specjalność";
            this.specjalnosc.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rockwell", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zalogowano jako:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Rockwell", 8.25F);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.lblLogin.Location = new System.Drawing.Point(95, 5);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "label2";
            // 
            // btnWyloguj
            // 
            this.btnWyloguj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.btnWyloguj.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.btnWyloguj.ForeColor = System.Drawing.Color.White;
            this.btnWyloguj.Location = new System.Drawing.Point(806, 37);
            this.btnWyloguj.Margin = new System.Windows.Forms.Padding(2);
            this.btnWyloguj.Name = "btnWyloguj";
            this.btnWyloguj.Size = new System.Drawing.Size(175, 73);
            this.btnWyloguj.TabIndex = 3;
            this.btnWyloguj.Text = "Wyloguj się";
            this.btnWyloguj.UseVisualStyleBackColor = false;
            this.btnWyloguj.Click += new System.EventHandler(this.btnWyloguj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDodaj.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(20, 468);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(175, 73);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj pracownika";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.Crimson;
            this.btnUsun.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.btnUsun.ForeColor = System.Drawing.Color.White;
            this.btnUsun.Location = new System.Drawing.Point(416, 468);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(175, 73);
            this.btnUsun.TabIndex = 5;
            this.btnUsun.Text = "Usuń pracownika";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDyzury
            // 
            this.btnDyzury.BackColor = System.Drawing.Color.Purple;
            this.btnDyzury.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.btnDyzury.ForeColor = System.Drawing.Color.White;
            this.btnDyzury.Location = new System.Drawing.Point(615, 468);
            this.btnDyzury.Margin = new System.Windows.Forms.Padding(2);
            this.btnDyzury.Name = "btnDyzury";
            this.btnDyzury.Size = new System.Drawing.Size(175, 73);
            this.btnDyzury.TabIndex = 6;
            this.btnDyzury.Text = "Zobacz dyżury";
            this.btnDyzury.UseVisualStyleBackColor = false;
            this.btnDyzury.Click += new System.EventHandler(this.btnDyzury_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(1)))), ((int)(((byte)(113)))));
            this.btnEdytuj.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.btnEdytuj.ForeColor = System.Drawing.Color.White;
            this.btnEdytuj.Location = new System.Drawing.Point(216, 468);
            this.btnEdytuj.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(175, 73);
            this.btnEdytuj.TabIndex = 7;
            this.btnEdytuj.Text = "Edytuj pracownika";
            this.btnEdytuj.UseVisualStyleBackColor = false;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(806, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // WidokGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDyzury);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnWyloguj);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvPracownicy);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WidokGlowny";
            this.Size = new System.Drawing.Size(1030, 802);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPracownicy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ColumnHeader imie;
        private System.Windows.Forms.ColumnHeader nazwisko;
        private System.Windows.Forms.ColumnHeader stanowisko;
        private System.Windows.Forms.Button btnWyloguj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDyzury;
        private System.Windows.Forms.ColumnHeader specjalnosc;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
