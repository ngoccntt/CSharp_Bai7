namespace CSharp_Bai7
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
            this.btnGiaiPT = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoA = new System.Windows.Forms.TextBox();
            this.txtsoB = new System.Windows.Forms.TextBox();
            this.txtsoC = new System.Windows.Forms.TextBox();
            this.trbsoA = new System.Windows.Forms.TrackBar();
            this.trbsoC = new System.Windows.Forms.TrackBar();
            this.trbsoB = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.lblPT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbsoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbsoC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbsoB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình Bậc 2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGiaiPT
            // 
            this.btnGiaiPT.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiPT.Location = new System.Drawing.Point(95, 264);
            this.btnGiaiPT.Name = "btnGiaiPT";
            this.btnGiaiPT.Size = new System.Drawing.Size(305, 41);
            this.btnGiaiPT.TabIndex = 1;
            this.btnGiaiPT.Text = "GIẢI PHƯƠNG TRÌNH";
            this.btnGiaiPT.UseVisualStyleBackColor = true;
            this.btnGiaiPT.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 10);
            this.progressBar1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập B";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập C";
            // 
            // txtsoA
            // 
            this.txtsoA.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoA.Location = new System.Drawing.Point(129, 105);
            this.txtsoA.Name = "txtsoA";
            this.txtsoA.Size = new System.Drawing.Size(116, 32);
            this.txtsoA.TabIndex = 4;
            this.txtsoA.Text = "1";
            this.txtsoA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsoB
            // 
            this.txtsoB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoB.Location = new System.Drawing.Point(129, 158);
            this.txtsoB.Name = "txtsoB";
            this.txtsoB.Size = new System.Drawing.Size(116, 32);
            this.txtsoB.TabIndex = 4;
            this.txtsoB.Text = "2";
            this.txtsoB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsoC
            // 
            this.txtsoC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoC.Location = new System.Drawing.Point(129, 212);
            this.txtsoC.Name = "txtsoC";
            this.txtsoC.Size = new System.Drawing.Size(116, 32);
            this.txtsoC.TabIndex = 4;
            this.txtsoC.Text = "1";
            this.txtsoC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // trbsoA
            // 
            this.trbsoA.Location = new System.Drawing.Point(300, 105);
            this.trbsoA.Name = "trbsoA";
            this.trbsoA.Size = new System.Drawing.Size(283, 45);
            this.trbsoA.TabIndex = 5;
            // 
            // trbsoC
            // 
            this.trbsoC.Location = new System.Drawing.Point(300, 213);
            this.trbsoC.Name = "trbsoC";
            this.trbsoC.Size = new System.Drawing.Size(283, 45);
            this.trbsoC.TabIndex = 5;
            // 
            // trbsoB
            // 
            this.trbsoB.Location = new System.Drawing.Point(300, 156);
            this.trbsoB.Name = "trbsoB";
            this.trbsoB.Size = new System.Drawing.Size(283, 45);
            this.trbsoB.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKQ);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 162);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KẾT QUẢ";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(30, 51);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(312, 31);
            this.lblKQ.TabIndex = 0;
            this.lblKQ.Text = "Hãy bấm Giải phương trình";
            // 
            // lblPT
            // 
            this.lblPT.AutoSize = true;
            this.lblPT.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPT.Location = new System.Drawing.Point(318, 61);
            this.lblPT.Name = "lblPT";
            this.lblPT.Size = new System.Drawing.Size(140, 31);
            this.lblPT.TabIndex = 7;
            this.lblPT.Text = "DYNAMIC";
            this.lblPT.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.lblPT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trbsoB);
            this.Controls.Add(this.trbsoC);
            this.Controls.Add(this.trbsoA);
            this.Controls.Add(this.txtsoC);
            this.Controls.Add(this.txtsoB);
            this.Controls.Add(this.txtsoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGiaiPT);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Trang Chủ";
            ((System.ComponentModel.ISupportInitialize)(this.trbsoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbsoC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbsoB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiaiPT;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoA;
        private System.Windows.Forms.TextBox txtsoB;
        private System.Windows.Forms.TextBox txtsoC;
        private System.Windows.Forms.TrackBar trbsoA;
        private System.Windows.Forms.TrackBar trbsoC;
        private System.Windows.Forms.TrackBar trbsoB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Label lblPT;
    }
}

