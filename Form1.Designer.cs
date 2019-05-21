namespace Son
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
            this.button_SelectAddWord = new System.Windows.Forms.Button();
            this.button_Learn = new System.Windows.Forms.Button();
            this.button_Test = new System.Windows.Forms.Button();
            this.button_LearnedWords = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SelectAddWord
            // 
            this.button_SelectAddWord.BackColor = System.Drawing.Color.Snow;
            this.button_SelectAddWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SelectAddWord.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.button_SelectAddWord.Location = new System.Drawing.Point(459, 240);
            this.button_SelectAddWord.Name = "button_SelectAddWord";
            this.button_SelectAddWord.Size = new System.Drawing.Size(471, 79);
            this.button_SelectAddWord.TabIndex = 2;
            this.button_SelectAddWord.Text = "KELİME SEÇME VEYA EKLEME";
            this.button_SelectAddWord.UseVisualStyleBackColor = false;
            this.button_SelectAddWord.Click += new System.EventHandler(this.button_SelectAddWord_Click);
            // 
            // button_Learn
            // 
            this.button_Learn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Learn.BackColor = System.Drawing.Color.Snow;
            this.button_Learn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Learn.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.button_Learn.Location = new System.Drawing.Point(459, 30);
            this.button_Learn.Name = "button_Learn";
            this.button_Learn.Size = new System.Drawing.Size(471, 79);
            this.button_Learn.TabIndex = 0;
            this.button_Learn.Text = "ÖĞREN";
            this.button_Learn.UseVisualStyleBackColor = false;
            this.button_Learn.Click += new System.EventHandler(this.button_Learn_Click);
            // 
            // button_Test
            // 
            this.button_Test.BackColor = System.Drawing.Color.Snow;
            this.button_Test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Test.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.button_Test.Location = new System.Drawing.Point(459, 135);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(471, 79);
            this.button_Test.TabIndex = 1;
            this.button_Test.Text = "SINAV";
            this.button_Test.UseVisualStyleBackColor = false;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // button_LearnedWords
            // 
            this.button_LearnedWords.BackColor = System.Drawing.Color.Snow;
            this.button_LearnedWords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_LearnedWords.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.button_LearnedWords.Location = new System.Drawing.Point(459, 345);
            this.button_LearnedWords.Name = "button_LearnedWords";
            this.button_LearnedWords.Size = new System.Drawing.Size(471, 79);
            this.button_LearnedWords.TabIndex = 3;
            this.button_LearnedWords.Text = "ÖĞRENİLEN KELİMELER";
            this.button_LearnedWords.UseVisualStyleBackColor = false;
            this.button_LearnedWords.Click += new System.EventHandler(this.button_LearnedWords_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Snow;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.button_Exit.Location = new System.Drawing.Point(459, 450);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(471, 79);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "ÇIKIŞ";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Son.Properties.Resources.Education_Background_Vector_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 559);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_LearnedWords);
            this.Controls.Add(this.button_Test);
            this.Controls.Add(this.button_Learn);
            this.Controls.Add(this.button_SelectAddWord);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_SelectAddWord;
		private System.Windows.Forms.Button button_Learn;
		private System.Windows.Forms.Button button_Test;
		private System.Windows.Forms.Button button_LearnedWords;
		private System.Windows.Forms.Button button_Exit;
	}
}

