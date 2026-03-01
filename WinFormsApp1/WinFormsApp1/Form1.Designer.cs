namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			label4 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(391, 34);
			label1.Name = "label1";
			label1.Size = new Size(240, 41);
			label1.TabIndex = 1;
			label1.Text = "Basic Operation";
			label1.TextAlign = ContentAlignment.TopCenter;
			label1.Click += label1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(391, 159);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(273, 27);
			textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(391, 237);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(273, 27);
			textBox2.TabIndex = 3;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(237, 159);
			label2.Name = "label2";
			label2.Size = new Size(117, 41);
			label2.TabIndex = 4;
			label2.Text = "Value-1";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(237, 237);
			label3.Name = "label3";
			label3.Size = new Size(113, 38);
			label3.TabIndex = 5;
			label3.Text = "Value-2";
			// 
			// button1
			// 
			button1.Location = new Point(222, 319);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 6;
			button1.Text = "+";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
			// 
			// button2
			// 
			button2.Location = new Point(374, 319);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 7;
			button2.Text = "-";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(524, 319);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 8;
			button3.Text = "X";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(661, 319);
			button4.Name = "button4";
			button4.Size = new Size(94, 29);
			button4.TabIndex = 9;
			button4.Text = "/";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(330, 413);
			label4.Name = "label4";
			label4.Size = new Size(0, 41);
			label4.TabIndex = 10;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 255, 128);
			ClientSize = new Size(1037, 573);
			Controls.Add(label4);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label2;
		private Label label3;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Label label4;
	}
}
