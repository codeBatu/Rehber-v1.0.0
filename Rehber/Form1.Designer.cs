
namespace Rehber
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextTel = new System.Windows.Forms.MaskedTextBox();
            this.TextMail = new System.Windows.Forms.TextBox();
            this.ComboGmail = new System.Windows.Forms.ComboBox();
            this.ComboCinsiyet = new System.Windows.Forms.ComboBox();
            this.ButtonEkle = new System.Windows.Forms.Button();
            this.ButtonSil = new System.Windows.Forms.Button();
            this.ButtonGüncelle = new System.Windows.Forms.Button();
            this.ButtonYenile = new System.Windows.Forms.Button();
            this.GridRehber = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridRehber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cinsiyet";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(141, 40);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(156, 20);
            this.TextName.TabIndex = 4;
            // 
            // TextTel
            // 
            this.TextTel.Location = new System.Drawing.Point(141, 71);
            this.TextTel.Mask = "(999) 000-0000";
            this.TextTel.Name = "TextTel";
            this.TextTel.Size = new System.Drawing.Size(156, 20);
            this.TextTel.TabIndex = 5;
            // 
            // TextMail
            // 
            this.TextMail.Location = new System.Drawing.Point(141, 98);
            this.TextMail.Name = "TextMail";
            this.TextMail.Size = new System.Drawing.Size(156, 20);
            this.TextMail.TabIndex = 6;
            // 
            // ComboGmail
            // 
            this.ComboGmail.FormattingEnabled = true;
            this.ComboGmail.Items.AddRange(new object[] {
            "@gmail.com",
            "@outlook.com",
            "@hotmail.com",
            "                            "});
            this.ComboGmail.Location = new System.Drawing.Point(303, 98);
            this.ComboGmail.Name = "ComboGmail";
            this.ComboGmail.Size = new System.Drawing.Size(67, 21);
            this.ComboGmail.TabIndex = 7;
            // 
            // ComboCinsiyet
            // 
            this.ComboCinsiyet.FormattingEnabled = true;
            this.ComboCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.ComboCinsiyet.Location = new System.Drawing.Point(141, 124);
            this.ComboCinsiyet.Name = "ComboCinsiyet";
            this.ComboCinsiyet.Size = new System.Drawing.Size(156, 21);
            this.ComboCinsiyet.TabIndex = 8;
            // 
            // ButtonEkle
            // 
            this.ButtonEkle.Location = new System.Drawing.Point(77, 200);
            this.ButtonEkle.Name = "ButtonEkle";
            this.ButtonEkle.Size = new System.Drawing.Size(75, 23);
            this.ButtonEkle.TabIndex = 9;
            this.ButtonEkle.Text = "EKLE";
            this.ButtonEkle.UseVisualStyleBackColor = true;
            this.ButtonEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonSil
            // 
            this.ButtonSil.Location = new System.Drawing.Point(158, 200);
            this.ButtonSil.Name = "ButtonSil";
            this.ButtonSil.Size = new System.Drawing.Size(75, 23);
            this.ButtonSil.TabIndex = 10;
            this.ButtonSil.Text = "Sil";
            this.ButtonSil.UseVisualStyleBackColor = true;
            this.ButtonSil.Click += new System.EventHandler(this.ButtonSil_Click);
            // 
            // ButtonGüncelle
            // 
            this.ButtonGüncelle.Location = new System.Drawing.Point(239, 200);
            this.ButtonGüncelle.Name = "ButtonGüncelle";
            this.ButtonGüncelle.Size = new System.Drawing.Size(75, 23);
            this.ButtonGüncelle.TabIndex = 11;
            this.ButtonGüncelle.Text = "Güncelle";
            this.ButtonGüncelle.UseVisualStyleBackColor = true;
            this.ButtonGüncelle.Click += new System.EventHandler(this.ButtonGüncelle_Click);
            // 
            // ButtonYenile
            // 
            this.ButtonYenile.Location = new System.Drawing.Point(77, 242);
            this.ButtonYenile.Name = "ButtonYenile";
            this.ButtonYenile.Size = new System.Drawing.Size(247, 54);
            this.ButtonYenile.TabIndex = 12;
            this.ButtonYenile.Text = "Yenile";
            this.ButtonYenile.UseVisualStyleBackColor = true;
            // 
            // GridRehber
            // 
            this.GridRehber.AllowUserToAddRows = false;
            this.GridRehber.AllowUserToDeleteRows = false;
            this.GridRehber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridRehber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRehber.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.GridRehber.Location = new System.Drawing.Point(388, 40);
            this.GridRehber.Name = "GridRehber";
            this.GridRehber.ReadOnly = true;
            this.GridRehber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridRehber.Size = new System.Drawing.Size(801, 340);
            this.GridRehber.TabIndex = 13;
            this.GridRehber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.GridRehber.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridRehber_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 450);
            this.Controls.Add(this.GridRehber);
            this.Controls.Add(this.ButtonYenile);
            this.Controls.Add(this.ButtonGüncelle);
            this.Controls.Add(this.ButtonSil);
            this.Controls.Add(this.ButtonEkle);
            this.Controls.Add(this.ComboCinsiyet);
            this.Controls.Add(this.ComboGmail);
            this.Controls.Add(this.TextMail);
            this.Controls.Add(this.TextTel);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridRehber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.MaskedTextBox TextTel;
        private System.Windows.Forms.TextBox TextMail;
        private System.Windows.Forms.ComboBox ComboGmail;
        private System.Windows.Forms.ComboBox ComboCinsiyet;
        private System.Windows.Forms.Button ButtonEkle;
        private System.Windows.Forms.Button ButtonSil;
        private System.Windows.Forms.Button ButtonGüncelle;
        private System.Windows.Forms.Button ButtonYenile;
        private System.Windows.Forms.DataGridView GridRehber;
    }
}

