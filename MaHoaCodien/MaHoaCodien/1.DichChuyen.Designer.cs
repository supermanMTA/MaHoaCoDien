﻿namespace MaHoaCodien
{
    partial class DichChuyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.txtKey = new System.Windows.Forms.NumericUpDown();
            this.btnMahoa = new System.Windows.Forms.Button();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.btnThamma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtKey)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn khóa";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 45);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(312, 149);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(13, 258);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(312, 129);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.Text = "";
            // 
            // txtKey
            // 
            this.txtKey.AutoSize = true;
            this.txtKey.Location = new System.Drawing.Point(440, 48);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(74, 20);
            this.txtKey.TabIndex = 5;
            // 
            // btnMahoa
            // 
            this.btnMahoa.Location = new System.Drawing.Point(359, 109);
            this.btnMahoa.Name = "btnMahoa";
            this.btnMahoa.Size = new System.Drawing.Size(75, 23);
            this.btnMahoa.TabIndex = 6;
            this.btnMahoa.Text = "Mã hóa";
            this.btnMahoa.UseVisualStyleBackColor = true;
            this.btnMahoa.Click += new System.EventHandler(this.btnMahoa_Click);
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(469, 109);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiMa.TabIndex = 7;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // btnThamma
            // 
            this.btnThamma.Location = new System.Drawing.Point(358, 171);
            this.btnThamma.Name = "btnThamma";
            this.btnThamma.Size = new System.Drawing.Size(75, 23);
            this.btnThamma.TabIndex = 8;
            this.btnThamma.Text = "Thám mã";
            this.btnThamma.UseVisualStyleBackColor = true;
            this.btnThamma.Click += new System.EventHandler(this.btnThamma_Click);
            // 
            // DichChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThamma);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnMahoa);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "DichChuyen";
            this.Size = new System.Drawing.Size(573, 439);
            ((System.ComponentModel.ISupportInitialize)(this.txtKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.NumericUpDown txtKey;
        private System.Windows.Forms.Button btnMahoa;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Button btnThamma;
    }
}
