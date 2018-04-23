namespace MaHoaCodien
{
    partial class HoanVi
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
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.btnTaokhoa = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.RichTextBox();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.btnMahoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(34, 260);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(287, 157);
            this.txtOutput.TabIndex = 66;
            this.txtOutput.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Input";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(43, 59);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(278, 162);
            this.txtInput.TabIndex = 63;
            this.txtInput.Text = "";
            // 
            // btnTaokhoa
            // 
            this.btnTaokhoa.Location = new System.Drawing.Point(388, 83);
            this.btnTaokhoa.Name = "btnTaokhoa";
            this.btnTaokhoa.Size = new System.Drawing.Size(75, 23);
            this.btnTaokhoa.TabIndex = 70;
            this.btnTaokhoa.Text = "Tạo khóa";
            this.btnTaokhoa.UseVisualStyleBackColor = true;
            this.btnTaokhoa.Click += new System.EventHandler(this.btnTaokhoa_Click);
            // 
            // txtKey
            // 
            this.txtKey.Enabled = false;
            this.txtKey.Location = new System.Drawing.Point(351, 128);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(175, 21);
            this.txtKey.TabIndex = 69;
            this.txtKey.Text = "";
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(476, 182);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiMa.TabIndex = 68;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // btnMahoa
            // 
            this.btnMahoa.Location = new System.Drawing.Point(351, 182);
            this.btnMahoa.Name = "btnMahoa";
            this.btnMahoa.Size = new System.Drawing.Size(75, 23);
            this.btnMahoa.TabIndex = 67;
            this.btnMahoa.Text = "Mã hóa";
            this.btnMahoa.UseVisualStyleBackColor = true;
            this.btnMahoa.Click += new System.EventHandler(this.btnMahoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "số khóa";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(388, 57);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(120, 20);
            this.txtNumber.TabIndex = 72;
            // 
            // HoanVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaokhoa);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnMahoa);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Name = "HoanVi";
            this.Size = new System.Drawing.Size(588, 472);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Button btnTaokhoa;
        private System.Windows.Forms.RichTextBox txtKey;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Button btnMahoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtNumber;
    }
}
