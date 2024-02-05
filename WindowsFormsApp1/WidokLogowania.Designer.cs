
namespace SzpitalGUI
{
    partial class WidokLogowania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WidokLogowania));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNazwaUzytkownika = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Zarządzania Szpitalem";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbHaslo);
            this.groupBox1.Controls.Add(this.btnZaloguj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNazwaUzytkownika);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(980, 512);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logowanie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(283, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasło";
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(379, 197);
            this.tbHaslo.Margin = new System.Windows.Forms.Padding(2);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '•';
            this.tbHaslo.Size = new System.Drawing.Size(199, 39);
            this.tbHaslo.TabIndex = 2;
            this.tbHaslo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbHaslo_KeyDown);
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.btnZaloguj.ForeColor = System.Drawing.Color.White;
            this.btnZaloguj.Location = new System.Drawing.Point(393, 276);
            this.btnZaloguj.Margin = new System.Windows.Forms.Padding(2);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(175, 73);
            this.btnZaloguj.TabIndex = 3;
            this.btnZaloguj.Text = "Zaloguj się";
            this.btnZaloguj.UseVisualStyleBackColor = false;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(283, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // tbNazwaUzytkownika
            // 
            this.tbNazwaUzytkownika.Location = new System.Drawing.Point(379, 136);
            this.tbNazwaUzytkownika.Margin = new System.Windows.Forms.Padding(2);
            this.tbNazwaUzytkownika.Name = "tbNazwaUzytkownika";
            this.tbNazwaUzytkownika.Size = new System.Drawing.Size(199, 39);
            this.tbNazwaUzytkownika.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(770, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // WidokLogowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WidokLogowania";
            this.Size = new System.Drawing.Size(1030, 802);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNazwaUzytkownika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
