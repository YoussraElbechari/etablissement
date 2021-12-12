
namespace Eta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnacceuil = new System.Windows.Forms.Button();
            this.btnpaiement = new System.Windows.Forms.Button();
            this.btnensignant = new System.Windows.Forms.Button();
            this.btninsciption = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inscription1 = new Eta.Users.Inscription();
            this.acceil1 = new Eta.Users.Acceil();
            this.ensignant1 = new Eta.Users.Ensignant();
            this.payment1 = new Eta.Users.Payment();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(28)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 64);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1052, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 64);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(257, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etablisement El Bechari";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(28)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.btnacceuil);
            this.panel2.Controls.Add(this.btnpaiement);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnensignant);
            this.panel2.Controls.Add(this.btninsciption);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 628);
            this.panel2.TabIndex = 1;
            // 
            // btnacceuil
            // 
            this.btnacceuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(28)))), ((int)(((byte)(95)))));
            this.btnacceuil.FlatAppearance.BorderSize = 0;
            this.btnacceuil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacceuil.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacceuil.ForeColor = System.Drawing.Color.Black;
            this.btnacceuil.Image = ((System.Drawing.Image)(resources.GetObject("btnacceuil.Image")));
            this.btnacceuil.Location = new System.Drawing.Point(-15, 191);
            this.btnacceuil.Name = "btnacceuil";
            this.btnacceuil.Size = new System.Drawing.Size(223, 78);
            this.btnacceuil.TabIndex = 5;
            this.btnacceuil.Text = "Acceuil   ";
            this.btnacceuil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnacceuil.UseVisualStyleBackColor = false;
            this.btnacceuil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnpaiement
            // 
            this.btnpaiement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(28)))), ((int)(((byte)(95)))));
            this.btnpaiement.FlatAppearance.BorderSize = 0;
            this.btnpaiement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpaiement.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaiement.Image = ((System.Drawing.Image)(resources.GetObject("btnpaiement.Image")));
            this.btnpaiement.Location = new System.Drawing.Point(-12, 443);
            this.btnpaiement.Name = "btnpaiement";
            this.btnpaiement.Size = new System.Drawing.Size(223, 78);
            this.btnpaiement.TabIndex = 4;
            this.btnpaiement.Text = "Paiement  ";
            this.btnpaiement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnpaiement.UseVisualStyleBackColor = false;
            this.btnpaiement.Click += new System.EventHandler(this.btnpaiement_Click);
            // 
            // btnensignant
            // 
            this.btnensignant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(28)))), ((int)(((byte)(95)))));
            this.btnensignant.FlatAppearance.BorderSize = 0;
            this.btnensignant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnensignant.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnensignant.Image = ((System.Drawing.Image)(resources.GetObject("btnensignant.Image")));
            this.btnensignant.Location = new System.Drawing.Point(-15, 359);
            this.btnensignant.Name = "btnensignant";
            this.btnensignant.Size = new System.Drawing.Size(223, 78);
            this.btnensignant.TabIndex = 3;
            this.btnensignant.Text = "Ensignant";
            this.btnensignant.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnensignant.UseVisualStyleBackColor = false;
            this.btnensignant.Click += new System.EventHandler(this.button4_Click);
            // 
            // btninsciption
            // 
            this.btninsciption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(28)))), ((int)(((byte)(95)))));
            this.btninsciption.FlatAppearance.BorderSize = 0;
            this.btninsciption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsciption.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsciption.Image = ((System.Drawing.Image)(resources.GetObject("btninsciption.Image")));
            this.btninsciption.Location = new System.Drawing.Point(-12, 275);
            this.btninsciption.Name = "btninsciption";
            this.btninsciption.Size = new System.Drawing.Size(220, 78);
            this.btninsciption.TabIndex = 2;
            this.btninsciption.Text = "Inscription";
            this.btninsciption.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btninsciption.UseVisualStyleBackColor = false;
            this.btninsciption.Click += new System.EventHandler(this.btninsciption_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-24, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inscription1
            // 
            this.inscription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inscription1.Location = new System.Drawing.Point(205, 64);
            this.inscription1.Name = "inscription1";
            this.inscription1.Size = new System.Drawing.Size(906, 628);
            this.inscription1.TabIndex = 3;
            // 
            // acceil1
            // 
            this.acceil1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceil1.Location = new System.Drawing.Point(205, 64);
            this.acceil1.Name = "acceil1";
            this.acceil1.Size = new System.Drawing.Size(906, 628);
            this.acceil1.TabIndex = 2;
            // 
            // ensignant1
            // 
            this.ensignant1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ensignant1.Location = new System.Drawing.Point(205, 64);
            this.ensignant1.Name = "ensignant1";
            this.ensignant1.Size = new System.Drawing.Size(906, 628);
            this.ensignant1.TabIndex = 4;
            // 
            // payment1
            // 
            this.payment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payment1.Location = new System.Drawing.Point(205, 64);
            this.payment1.Name = "payment1";
            this.payment1.Size = new System.Drawing.Size(906, 628);
            this.payment1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 692);
            this.Controls.Add(this.payment1);
            this.Controls.Add(this.ensignant1);
            this.Controls.Add(this.inscription1);
            this.Controls.Add(this.acceil1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnpaiement;
        private System.Windows.Forms.Button btnensignant;
        private System.Windows.Forms.Button btninsciption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnacceuil;
        private Users.Acceil acceil1;
        private Users.Inscription inscription1;
        private Users.Ensignant ensignant1;
        private Users.Payment payment1;
    }
}

