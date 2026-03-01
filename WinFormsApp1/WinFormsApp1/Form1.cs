namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			if (textBox1.Text != "" && textBox2.Text != "")
			{
				int v1, v2, res;
			v1 = Convert.ToInt32(textBox1.Text);
			v2 = Convert.ToInt32(textBox2.Text);
			res = v1 + v2;
			//MessageBox.Show("Addition is " + res.ToString());
			label4.Text = "Addition is " + res.ToString();
			}
			else
			{
				label4.Text = "Please Enter The Valied Value !";
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" && textBox2.Text != "")
			{
				int v1, v2, res;
			v1 = Convert.ToInt32(textBox1.Text);
			v2 = Convert.ToInt32(textBox2.Text);
			res = v1 - v2;
			//MessageBox.Show("Addition is " + res.ToString());
			label4.Text = "Subtraction is " + res.ToString();
			}
			else
			{
				label4.Text = "Please Enter The Valied Value !";
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" && textBox2.Text != "")
			{
				int v1, v2, res;
			v1 = int.Parse(textBox1.Text);
			v2 = int.Parse(textBox2.Text);

			res = v1 * v2;
			label4.Text = "Multiplication is " + res.ToString();

		}
			else
			{
				label4.Text = "Please Enter The Valied Value !";
			}
}

		private void button4_Click(object sender, EventArgs e)
		{
			if(textBox1.Text != "" && textBox2.Text != "")
			{

			int v1, v2, res;
			v1 = int.Parse((String)textBox1.Text);
			v2 = int.Parse((String)textBox2.Text);

			res = v1 / v2;

			label4.Text = "Division is " + res.ToString();
			}
			else
			{
				label4.Text = "Please Enter The Valied Value !";
			}
		}

	}
}
