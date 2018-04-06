namespace MaHoaCodien
{
    partial class ThayThe
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
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.btnMahoa = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.txtRandom = new System.Windows.Forms.RichTextBox();
            this.btnTaokhoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(548, 159);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiMa.TabIndex = 15;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // btnMahoa
            // 
            this.btnMahoa.Location = new System.Drawing.Point(434, 159);
            this.btnMahoa.Name = "btnMahoa";
            this.btnMahoa.Size = new System.Drawing.Size(75, 23);
            this.btnMahoa.TabIndex = 14;
            this.btnMahoa.Text = "Mã hóa";
            this.btnMahoa.UseVisualStyleBackColor = true;
            this.btnMahoa.Click += new System.EventHandler(this.btnMahoa_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(36, 265);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(340, 157);
            this.txtOutput.TabIndex = 12;
            this.txtOutput.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Input";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(36, 52);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(344, 162);
            this.txtInput.TabIndex = 9;
            this.txtInput.Text = "";
            // 
            // txtRandom
            // 
            this.txtRandom.Enabled = false;
            this.txtRandom.Location = new System.Drawing.Point(418, 73);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.Size = new System.Drawing.Size(228, 50);
            this.txtRandom.TabIndex = 16;
            this.txtRandom.Text = "";
            // 
            // btnTaokhoa
            // 
            this.btnTaokhoa.Location = new System.Drawing.Point(418, 44);
            this.btnTaokhoa.Name = "btnTaokhoa";
            this.btnTaokhoa.Size = new System.Drawing.Size(75, 23);
            this.btnTaokhoa.TabIndex = 17;
            this.btnTaokhoa.Text = "Tạo khóa";
            this.btnTaokhoa.UseVisualStyleBackColor = true;
            this.btnTaokhoa.Click += new System.EventHandler(this.btnTaokhoa_Click);
            // 
            // ThayThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTaokhoa);
            this.Controls.Add(this.txtRandom);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnMahoa);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Name = "ThayThe";
            this.Size = new System.Drawing.Size(663, 557);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Button btnMahoa;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.RichTextBox txtRandom;
        private System.Windows.Forms.Button btnTaokhoa;
    }
}
