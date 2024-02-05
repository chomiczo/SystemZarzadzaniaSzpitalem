
namespace SzpitalGUI
{
    partial class WidokPracownika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WidokPracownika));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTypKonta = new System.Windows.Forms.ComboBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPesel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSpecjalnosc = new System.Windows.Forms.ComboBox();
            this.gbSzczegoly = new System.Windows.Forms.GroupBox();
            this.tbPWZ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbSzczegoly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbTypKonta);
            this.groupBox1.Controls.Add(this.tbHaslo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbLogin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPesel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNazwisko);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbImie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.groupBox1.Location = new System.Drawing.Point(2, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(383, 409);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pracownik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Typ konta";
            // 
            // cbTypKonta
            // 
            this.cbTypKonta.FormattingEnabled = true;
            this.cbTypKonta.Items.AddRange(new object[] {
            "Administrator",
            "Lekarz",
            "Pielęgniarka"});
            this.cbTypKonta.Location = new System.Drawing.Point(170, 347);
            this.cbTypKonta.Margin = new System.Windows.Forms.Padding(2);
            this.cbTypKonta.Name = "cbTypKonta";
            this.cbTypKonta.Size = new System.Drawing.Size(199, 39);
            this.cbTypKonta.TabIndex = 10;
            this.cbTypKonta.SelectedIndexChanged += new System.EventHandler(this.cbTypKonta_SelectedIndexChanged);
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(170, 288);
            this.tbHaslo.Margin = new System.Windows.Forms.Padding(2);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '•';
            this.tbHaslo.Size = new System.Drawing.Size(199, 39);
            this.tbHaslo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hasło";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(170, 227);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(199, 39);
            this.tbLogin.TabIndex = 7;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // tbPesel
            // 
            this.tbPesel.Location = new System.Drawing.Point(170, 167);
            this.tbPesel.Margin = new System.Windows.Forms.Padding(2);
            this.tbPesel.MaxLength = 11;
            this.tbPesel.Name = "tbPesel";
            this.tbPesel.Size = new System.Drawing.Size(199, 39);
            this.tbPesel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "PESEL";
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Location = new System.Drawing.Point(170, 107);
            this.tbNazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(199, 39);
            this.tbNazwisko.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(170, 49);
            this.tbImie.Margin = new System.Windows.Forms.Padding(2);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(199, 39);
            this.tbImie.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Specjalność";
            // 
            // cbSpecjalnosc
            // 
            this.cbSpecjalnosc.FormattingEnabled = true;
            this.cbSpecjalnosc.Items.AddRange(new object[] {
            "kardiolog",
            "urolog",
            "neurolog",
            "laryngolog"});
            this.cbSpecjalnosc.Location = new System.Drawing.Point(240, 49);
            this.cbSpecjalnosc.Margin = new System.Windows.Forms.Padding(2);
            this.cbSpecjalnosc.Name = "cbSpecjalnosc";
            this.cbSpecjalnosc.Size = new System.Drawing.Size(199, 39);
            this.cbSpecjalnosc.TabIndex = 11;
            // 
            // gbSzczegoly
            // 
            this.gbSzczegoly.Controls.Add(this.tbPWZ);
            this.gbSzczegoly.Controls.Add(this.label8);
            this.gbSzczegoly.Controls.Add(this.label7);
            this.gbSzczegoly.Controls.Add(this.cbSpecjalnosc);
            this.gbSzczegoly.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.gbSzczegoly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.gbSzczegoly.Location = new System.Drawing.Point(389, 26);
            this.gbSzczegoly.Margin = new System.Windows.Forms.Padding(2);
            this.gbSzczegoly.Name = "gbSzczegoly";
            this.gbSzczegoly.Padding = new System.Windows.Forms.Padding(2);
            this.gbSzczegoly.Size = new System.Drawing.Size(449, 409);
            this.gbSzczegoly.TabIndex = 14;
            this.gbSzczegoly.TabStop = false;
            this.gbSzczegoly.Text = "Lekarz";
            // 
            // tbPWZ
            // 
            this.tbPWZ.Location = new System.Drawing.Point(240, 101);
            this.tbPWZ.Margin = new System.Windows.Forms.Padding(2);
            this.tbPWZ.MaxLength = 7;
            this.tbPWZ.Name = "tbPWZ";
            this.tbPWZ.Size = new System.Drawing.Size(199, 39);
            this.tbPWZ.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 101);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nr PWZ";
            // 
            // btnZapisz
            // 
            this.btnZapisz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.btnZapisz.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.btnZapisz.ForeColor = System.Drawing.Color.White;
            this.btnZapisz.Location = new System.Drawing.Point(663, 468);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(2);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(175, 73);
            this.btnZapisz.TabIndex = 15;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = false;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(1)))), ((int)(((byte)(113)))));
            this.btnAnuluj.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.btnAnuluj.ForeColor = System.Drawing.Color.White;
            this.btnAnuluj.Location = new System.Drawing.Point(461, 468);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(175, 73);
            this.btnAnuluj.TabIndex = 16;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = false;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 440);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(161, 440);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(285, 440);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // WidokPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.gbSzczegoly);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WidokPracownika";
            this.Size = new System.Drawing.Size(1030, 802);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSzczegoly.ResumeLayout(false);
            this.gbSzczegoly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTypKonta;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPesel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSpecjalnosc;
        private System.Windows.Forms.GroupBox gbSzczegoly;
        private System.Windows.Forms.TextBox tbPWZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
