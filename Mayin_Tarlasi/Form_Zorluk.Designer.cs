namespace Mayin_Tarlasi
{
    partial class Form_Zorluk
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
            this.radioButton_kolay = new System.Windows.Forms.RadioButton();
            this.radioButton_zor = new System.Windows.Forms.RadioButton();
            this.radioButton_orta = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_kolay
            // 
            this.radioButton_kolay.AutoSize = true;
            this.radioButton_kolay.Checked = true;
            this.radioButton_kolay.Location = new System.Drawing.Point(12, 12);
            this.radioButton_kolay.Name = "radioButton_kolay";
            this.radioButton_kolay.Size = new System.Drawing.Size(51, 17);
            this.radioButton_kolay.TabIndex = 0;
            this.radioButton_kolay.TabStop = true;
            this.radioButton_kolay.Text = "Kolay";
            this.radioButton_kolay.UseVisualStyleBackColor = true;
            // 
            // radioButton_zor
            // 
            this.radioButton_zor.AutoSize = true;
            this.radioButton_zor.Location = new System.Drawing.Point(12, 58);
            this.radioButton_zor.Name = "radioButton_zor";
            this.radioButton_zor.Size = new System.Drawing.Size(41, 17);
            this.radioButton_zor.TabIndex = 2;
            this.radioButton_zor.TabStop = true;
            this.radioButton_zor.Text = "Zor";
            this.radioButton_zor.UseVisualStyleBackColor = true;
            // 
            // radioButton_orta
            // 
            this.radioButton_orta.AutoSize = true;
            this.radioButton_orta.Location = new System.Drawing.Point(12, 35);
            this.radioButton_orta.Name = "radioButton_orta";
            this.radioButton_orta.Size = new System.Drawing.Size(45, 17);
            this.radioButton_orta.TabIndex = 3;
            this.radioButton_orta.TabStop = true;
            this.radioButton_orta.Text = "Orta";
            this.radioButton_orta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(62, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_Zorluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 118);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton_orta);
            this.Controls.Add(this.radioButton_zor);
            this.Controls.Add(this.radioButton_kolay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Zorluk";
            this.Text = "Zorluk Seviyesi Seş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Zorluk_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_kolay;
        private System.Windows.Forms.RadioButton radioButton_zor;
        private System.Windows.Forms.RadioButton radioButton_orta;
        private System.Windows.Forms.Button button1;
    }
}