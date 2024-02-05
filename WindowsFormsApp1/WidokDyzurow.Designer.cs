
namespace SzpitalGUI
{
    partial class WidokDyzurow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WidokDyzurow));
            this.lblTytul = new System.Windows.Forms.Label();
            this.dtpMiesiac = new System.Windows.Forms.DateTimePicker();
            this.lvDyzury = new System.Windows.Forms.ListView();
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpNowyDyzur = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnWroc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.lblTytul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.lblTytul.Location = new System.Drawing.Point(12, 11);
            this.lblTytul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(104, 31);
            this.lblTytul.TabIndex = 0;
            this.lblTytul.Text = "Dyżury";
            // 
            // dtpMiesiac
            // 
            this.dtpMiesiac.CustomFormat = "M-yyyy";
            this.dtpMiesiac.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.dtpMiesiac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMiesiac.Location = new System.Drawing.Point(452, 11);
            this.dtpMiesiac.Margin = new System.Windows.Forms.Padding(2);
            this.dtpMiesiac.Name = "dtpMiesiac";
            this.dtpMiesiac.Size = new System.Drawing.Size(146, 39);
            this.dtpMiesiac.TabIndex = 1;
            this.dtpMiesiac.ValueChanged += new System.EventHandler(this.dtpMiesiac_ValueChanged);
            // 
            // lvDyzury
            // 
            this.lvDyzury.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.data});
            this.lvDyzury.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lvDyzury.HideSelection = false;
            this.lvDyzury.Location = new System.Drawing.Point(15, 53);
            this.lvDyzury.Margin = new System.Windows.Forms.Padding(2);
            this.lvDyzury.Name = "lvDyzury";
            this.lvDyzury.Size = new System.Drawing.Size(936, 402);
            this.lvDyzury.TabIndex = 2;
            this.lvDyzury.UseCompatibleStateImageBehavior = false;
            this.lvDyzury.View = System.Windows.Forms.View.List;
            // 
            // data
            // 
            this.data.Text = "Data dyżuru";
            this.data.Width = 200;
            // 
            // dtpNowyDyzur
            // 
            this.dtpNowyDyzur.CalendarForeColor = System.Drawing.Color.White;
            this.dtpNowyDyzur.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.dtpNowyDyzur.Font = new System.Drawing.Font("Rockwell", 15.25F);
            this.dtpNowyDyzur.Location = new System.Drawing.Point(15, 473);
            this.dtpNowyDyzur.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNowyDyzur.Name = "dtpNowyDyzur";
            this.dtpNowyDyzur.Size = new System.Drawing.Size(359, 31);
            this.dtpNowyDyzur.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDodaj.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(389, 473);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(175, 73);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj dyżur";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.Crimson;
            this.btnUsun.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.btnUsun.ForeColor = System.Drawing.Color.White;
            this.btnUsun.Location = new System.Drawing.Point(585, 473);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(175, 73);
            this.btnUsun.TabIndex = 5;
            this.btnUsun.Text = "Usuń dyżury";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnWroc
            // 
            this.btnWroc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.btnWroc.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.btnWroc.ForeColor = System.Drawing.Color.White;
            this.btnWroc.Location = new System.Drawing.Point(776, 473);
            this.btnWroc.Margin = new System.Windows.Forms.Padding(2);
            this.btnWroc.Name = "btnWroc";
            this.btnWroc.Size = new System.Drawing.Size(175, 73);
            this.btnWroc.TabIndex = 6;
            this.btnWroc.Text = "Wróć";
            this.btnWroc.UseVisualStyleBackColor = false;
            this.btnWroc.Click += new System.EventHandler(this.btnWroc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(2)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(327, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Miesiąc: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(925, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // WidokDyzurow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWroc);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpNowyDyzur);
            this.Controls.Add(this.lvDyzury);
            this.Controls.Add(this.dtpMiesiac);
            this.Controls.Add(this.lblTytul);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WidokDyzurow";
            this.Size = new System.Drawing.Size(1030, 802);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.DateTimePicker dtpMiesiac;
        private System.Windows.Forms.ListView lvDyzury;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.DateTimePicker dtpNowyDyzur;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnWroc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
