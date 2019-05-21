namespace Son
{
	partial class Form_learnedWords
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.listBox1_words = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(460, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenilmiş Kelimeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(587, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 50);
            this.label2.TabIndex = 11;
            this.label2.Text = "İngilizcesi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 20F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(199, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 50);
            this.label6.TabIndex = 10;
            this.label6.Text = "Türkçesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(892, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 50);
            this.label3.TabIndex = 17;
            this.label3.Text = "Öğrenildiği Tarih";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Snow;
            this.button_back.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.button_back.Location = new System.Drawing.Point(459, 448);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(471, 79);
            this.button_back.TabIndex = 19;
            this.button_back.Text = "GERİ";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // listBox1_words
            // 
            this.listBox1_words.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.listBox1_words.FormattingEnabled = true;
            this.listBox1_words.ItemHeight = 37;
            this.listBox1_words.Location = new System.Drawing.Point(186, 186);
            this.listBox1_words.Name = "listBox1_words";
            this.listBox1_words.Size = new System.Drawing.Size(1020, 226);
            this.listBox1_words.TabIndex = 20;
            // 
            // Form_learnedWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Son.Properties.Resources.Education_Background_Vector_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 559);
            this.Controls.Add(this.listBox1_words);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_learnedWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenilmiş Kelimeler";
            this.Load += new System.EventHandler(this.Form_learnedWords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button_back;
		private System.Windows.Forms.ListBox listBox1_words;
	}
}