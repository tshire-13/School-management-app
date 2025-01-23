
namespace entleproject
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
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnaddstudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnameandsurname = new System.Windows.Forms.TextBox();
            this.txtexam2 = new System.Windows.Forms.TextBox();
            this.txtexam1 = new System.Windows.Forms.TextBox();
            this.txtidno = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnseacrh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(12, 482);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(230, 47);
            this.btndisplay.TabIndex = 0;
            this.btndisplay.Text = "Display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnaddstudent
            // 
            this.btnaddstudent.Location = new System.Drawing.Point(261, 482);
            this.btnaddstudent.Name = "btnaddstudent";
            this.btnaddstudent.Size = new System.Drawing.Size(230, 47);
            this.btnaddstudent.TabIndex = 1;
            this.btnaddstudent.Text = "Add student";
            this.btnaddstudent.UseVisualStyleBackColor = true;
            this.btnaddstudent.Click += new System.EventHandler(this.btnaddstudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAME and Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "id no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "exam 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(744, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "exam 2";
            // 
            // txtnameandsurname
            // 
            this.txtnameandsurname.Location = new System.Drawing.Point(886, 122);
            this.txtnameandsurname.Multiline = true;
            this.txtnameandsurname.Name = "txtnameandsurname";
            this.txtnameandsurname.Size = new System.Drawing.Size(216, 38);
            this.txtnameandsurname.TabIndex = 6;
            // 
            // txtexam2
            // 
            this.txtexam2.Location = new System.Drawing.Point(886, 257);
            this.txtexam2.Multiline = true;
            this.txtexam2.Name = "txtexam2";
            this.txtexam2.Size = new System.Drawing.Size(216, 38);
            this.txtexam2.TabIndex = 7;
            // 
            // txtexam1
            // 
            this.txtexam1.Location = new System.Drawing.Point(886, 213);
            this.txtexam1.Multiline = true;
            this.txtexam1.Name = "txtexam1";
            this.txtexam1.Size = new System.Drawing.Size(216, 38);
            this.txtexam1.TabIndex = 8;
            // 
            // txtidno
            // 
            this.txtidno.Location = new System.Drawing.Point(886, 169);
            this.txtidno.Multiline = true;
            this.txtidno.Name = "txtidno";
            this.txtidno.Size = new System.Drawing.Size(216, 38);
            this.txtidno.TabIndex = 9;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(886, 426);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(216, 38);
            this.txtsearch.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(883, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "seacrh for student";
            // 
            // btnseacrh
            // 
            this.btnseacrh.Location = new System.Drawing.Point(749, 426);
            this.btnseacrh.Name = "btnseacrh";
            this.btnseacrh.Size = new System.Drawing.Size(122, 38);
            this.btnseacrh.TabIndex = 12;
            this.btnseacrh.Text = "search student";
            this.btnseacrh.UseVisualStyleBackColor = true;
            this.btnseacrh.Click += new System.EventHandler(this.btnseacrh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 333);
            this.dataGridView1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "MANAGE STUDENT";
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(511, 482);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(230, 47);
            this.btnprint.TabIndex = 15;
            this.btnprint.Text = "PRINT REPORTS";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1162, 541);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnseacrh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtidno);
            this.Controls.Add(this.txtexam1);
            this.Controls.Add(this.txtexam2);
            this.Controls.Add(this.txtnameandsurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaddstudent);
            this.Controls.Add(this.btndisplay);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnaddstudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnameandsurname;
        private System.Windows.Forms.TextBox txtexam2;
        private System.Windows.Forms.TextBox txtexam1;
        private System.Windows.Forms.TextBox txtidno;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnseacrh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}