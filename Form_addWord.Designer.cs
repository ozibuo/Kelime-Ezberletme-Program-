namespace Son
{
	partial class Form_addWord
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
            this.button_back = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.listBox_library = new System.Windows.Forms.ListBox();
            this.label_turkish = new System.Windows.Forms.Label();
            this.label_english = new System.Windows.Forms.Label();
            this.textBox_exampleMean = new System.Windows.Forms.TextBox();
            this.label_example = new System.Windows.Forms.Label();
            this.textBox_example = new System.Windows.Forms.TextBox();
            this.label_exampleMean = new System.Windows.Forms.Label();
            this.textBox_english = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_turkish = new System.Windows.Forms.TextBox();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.label_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Snow;
            this.button_back.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.button_back.Location = new System.Drawing.Point(459, 444);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(471, 79);
            this.button_back.TabIndex = 7;
            this.button_back.Text = "GERİ";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.Snow;
            this.button_select.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.button_select.Location = new System.Drawing.Point(90, 321);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(471, 79);
            this.button_select.TabIndex = 9;
            this.button_select.Text = "SEÇ";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // listBox_library
            // 
            this.listBox_library.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.listBox_library.FormattingEnabled = true;
            this.listBox_library.ItemHeight = 37;
            this.listBox_library.Location = new System.Drawing.Point(62, 105);
            this.listBox_library.Name = "listBox_library";
            this.listBox_library.Size = new System.Drawing.Size(520, 189);
            this.listBox_library.TabIndex = 8;
            // 
            // label_turkish
            // 
            this.label_turkish.AutoSize = true;
            this.label_turkish.BackColor = System.Drawing.Color.Transparent;
            this.label_turkish.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.label_turkish.ForeColor = System.Drawing.SystemColors.Control;
            this.label_turkish.Location = new System.Drawing.Point(753, 72);
            this.label_turkish.Name = "label_turkish";
            this.label_turkish.Size = new System.Drawing.Size(135, 37);
            this.label_turkish.TabIndex = 10;
            this.label_turkish.Text = "Türkçesi:";
            this.label_turkish.Click += new System.EventHandler(this.label_turkish_Click);
            // 
            // label_english
            // 
            this.label_english.AutoSize = true;
            this.label_english.BackColor = System.Drawing.Color.Transparent;
            this.label_english.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.label_english.ForeColor = System.Drawing.SystemColors.Control;
            this.label_english.Location = new System.Drawing.Point(731, 122);
            this.label_english.Name = "label_english";
            this.label_english.Size = new System.Drawing.Size(157, 37);
            this.label_english.TabIndex = 11;
            this.label_english.Text = "İngilizcesi:";
            this.label_english.Click += new System.EventHandler(this.label_english_Click);
            // 
            // textBox_exampleMean
            // 
            this.textBox_exampleMean.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.textBox_exampleMean.Location = new System.Drawing.Point(922, 219);
            this.textBox_exampleMean.Name = "textBox_exampleMean";
            this.textBox_exampleMean.Size = new System.Drawing.Size(360, 39);
            this.textBox_exampleMean.TabIndex = 4;
            this.textBox_exampleMean.TextChanged += new System.EventHandler(this.textBox_exampleMean_TextChanged);
            // 
            // label_example
            // 
            this.label_example.AutoSize = true;
            this.label_example.BackColor = System.Drawing.Color.Transparent;
            this.label_example.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.label_example.ForeColor = System.Drawing.SystemColors.Control;
            this.label_example.Location = new System.Drawing.Point(675, 172);
            this.label_example.Name = "label_example";
            this.label_example.Size = new System.Drawing.Size(213, 37);
            this.label_example.TabIndex = 12;
            this.label_example.Text = "Örnek Cümlesi:";
            this.label_example.Click += new System.EventHandler(this.label_example_Click);
            // 
            // textBox_example
            // 
            this.textBox_example.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.textBox_example.Location = new System.Drawing.Point(922, 169);
            this.textBox_example.Name = "textBox_example";
            this.textBox_example.Size = new System.Drawing.Size(360, 39);
            this.textBox_example.TabIndex = 3;
            this.textBox_example.TextChanged += new System.EventHandler(this.textBox_example_TextChanged);
            // 
            // label_exampleMean
            // 
            this.label_exampleMean.AutoSize = true;
            this.label_exampleMean.BackColor = System.Drawing.Color.Transparent;
            this.label_exampleMean.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.label_exampleMean.ForeColor = System.Drawing.SystemColors.Control;
            this.label_exampleMean.Location = new System.Drawing.Point(642, 222);
            this.label_exampleMean.Name = "label_exampleMean";
            this.label_exampleMean.Size = new System.Drawing.Size(246, 37);
            this.label_exampleMean.TabIndex = 13;
            this.label_exampleMean.Text = "Cümlenin Anlamı:";
            this.label_exampleMean.Click += new System.EventHandler(this.label_exampleMean_Click);
            // 
            // textBox_english
            // 
            this.textBox_english.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.textBox_english.Location = new System.Drawing.Point(922, 119);
            this.textBox_english.Name = "textBox_english";
            this.textBox_english.Size = new System.Drawing.Size(360, 39);
            this.textBox_english.TabIndex = 2;
            this.textBox_english.TextChanged += new System.EventHandler(this.textBox_english_TextChanged);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Snow;
            this.button_add.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.button_add.Location = new System.Drawing.Point(796, 321);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(471, 79);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "EKLE";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_turkish
            // 
            this.textBox_turkish.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.textBox_turkish.Location = new System.Drawing.Point(922, 69);
            this.textBox_turkish.Name = "textBox_turkish";
            this.textBox_turkish.Size = new System.Drawing.Size(360, 39);
            this.textBox_turkish.TabIndex = 1;
            this.textBox_turkish.TextChanged += new System.EventHandler(this.textBox_turkish_TextChanged);
            // 
            // textBox_type
            // 
            this.textBox_type.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.textBox_type.Location = new System.Drawing.Point(922, 270);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(360, 39);
            this.textBox_type.TabIndex = 5;
            this.textBox_type.TextChanged += new System.EventHandler(this.textBox_type_TextChanged);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.BackColor = System.Drawing.Color.Transparent;
            this.label_type.Font = new System.Drawing.Font("Sitka Small", 15F);
            this.label_type.ForeColor = System.Drawing.SystemColors.Control;
            this.label_type.Location = new System.Drawing.Point(810, 273);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(78, 37);
            this.label_type.TabIndex = 16;
            this.label_type.Text = "Tipi:";
            this.label_type.Click += new System.EventHandler(this.label_type_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(503, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Öğrenmek İstediğiniz Kelimeleri Seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(764, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "KÜTÜPHANEYE KELİME EKLEYİN";
            // 
            // Form_addWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Son.Properties.Resources.Education_Background_Vector_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_turkish);
            this.Controls.Add(this.textBox_turkish);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_english);
            this.Controls.Add(this.textBox_english);
            this.Controls.Add(this.textBox_example);
            this.Controls.Add(this.label_exampleMean);
            this.Controls.Add(this.textBox_exampleMean);
            this.Controls.Add(this.label_example);
            this.Controls.Add(this.textBox_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_library);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_back);
            this.MaximizeBox = false;
            this.Name = "Form_addWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KELİME SEÇME VE EKLEME";
            this.Load += new System.EventHandler(this.Form_addWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.ListBox listBox_library;
        private System.Windows.Forms.Label label_turkish;
        private System.Windows.Forms.Label label_english;
        private System.Windows.Forms.TextBox textBox_exampleMean;
        private System.Windows.Forms.Label label_example;
        private System.Windows.Forms.TextBox textBox_example;
        private System.Windows.Forms.Label label_exampleMean;
        private System.Windows.Forms.TextBox textBox_english;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_turkish;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}