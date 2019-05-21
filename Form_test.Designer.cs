namespace Son
{
    partial class Form_test
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
            this.label_english = new System.Windows.Forms.Label();
            this.textBox_turkish = new System.Windows.Forms.TextBox();
            this.button_check = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_english
            // 
            this.label_english.BackColor = System.Drawing.Color.Transparent;
            this.label_english.Font = new System.Drawing.Font("Sitka Small", 25F);
            this.label_english.ForeColor = System.Drawing.SystemColors.Control;
            this.label_english.Location = new System.Drawing.Point(543, 64);
            this.label_english.Name = "label_english";
            this.label_english.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_english.Size = new System.Drawing.Size(311, 62);
            this.label_english.TabIndex = 0;
            this.label_english.Text = "KELİME";
            this.label_english.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_turkish
            // 
            this.textBox_turkish.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.textBox_turkish.Location = new System.Drawing.Point(459, 163);
            this.textBox_turkish.Name = "textBox_turkish";
            this.textBox_turkish.Size = new System.Drawing.Size(471, 39);
            this.textBox_turkish.TabIndex = 1;
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.Snow;
            this.button_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_check.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.button_check.Location = new System.Drawing.Point(459, 270);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(471, 79);
            this.button_check.TabIndex = 2;
            this.button_check.Text = "KONTROL ET";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Snow;
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.button_back.Location = new System.Drawing.Point(459, 415);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(471, 79);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "GERİ";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Form_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Son.Properties.Resources.Education_Background_Vector_7;
            this.ClientSize = new System.Drawing.Size(1338, 559);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.textBox_turkish);
            this.Controls.Add(this.label_english);
            this.MaximizeBox = false;
            this.Name = "Form_test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SINAV";
            this.Load += new System.EventHandler(this.Form_test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_turkish;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label_english;
    }
}