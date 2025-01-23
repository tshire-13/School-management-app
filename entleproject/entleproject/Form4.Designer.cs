
namespace entleproject
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
            this.label1 = new System.Windows.Forms.Label();
            this.btndisplay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnseacrh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtidno = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtisadmin = new System.Windows.Forms.TextBox();
            this.txtnameandsurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin page";
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(12, 438);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(205, 48);
            this.btndisplay.TabIndex = 1;
            this.btndisplay.Text = "Display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 327);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnseacrh
            // 
            this.btnseacrh.Location = new System.Drawing.Point(713, 451);
            this.btnseacrh.Name = "btnseacrh";
            this.btnseacrh.Size = new System.Drawing.Size(139, 38);
            this.btnseacrh.TabIndex = 15;
            this.btnseacrh.Text = "search credentials";
            this.btnseacrh.UseVisualStyleBackColor = true;
            this.btnseacrh.Click += new System.EventHandler(this.btnseacrh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(864, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "seacrh for student";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(867, 451);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(216, 38);
            this.txtsearch.TabIndex = 13;
            // 
            // txtidno
            // 
            this.txtidno.Location = new System.Drawing.Point(897, 168);
            this.txtidno.Multiline = true;
            this.txtidno.Name = "txtidno";
            this.txtidno.Size = new System.Drawing.Size(216, 38);
            this.txtidno.TabIndex = 23;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(897, 212);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(216, 38);
            this.txtpassword.TabIndex = 22;
            // 
            // txtisadmin
            // 
            this.txtisadmin.Location = new System.Drawing.Point(897, 256);
            this.txtisadmin.Multiline = true;
            this.txtisadmin.Name = "txtisadmin";
            this.txtisadmin.Size = new System.Drawing.Size(216, 38);
            this.txtisadmin.TabIndex = 21;
            // 
            // txtnameandsurname
            // 
            this.txtnameandsurname.Location = new System.Drawing.Point(897, 121);
            this.txtnameandsurname.Multiline = true;
            this.txtnameandsurname.Name = "txtnameandsurname";
            this.txtnameandsurname.Size = new System.Drawing.Size(216, 38);
            this.txtnameandsurname.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "isadmin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "id no";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(755, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "NAME and Surname";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(240, 432);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(177, 53);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1150, 595);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtidno);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtisadmin);
            this.Controls.Add(this.txtnameandsurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnseacrh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnseacrh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtidno;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtisadmin;
        private System.Windows.Forms.TextBox txtnameandsurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnupdate;
    }
}