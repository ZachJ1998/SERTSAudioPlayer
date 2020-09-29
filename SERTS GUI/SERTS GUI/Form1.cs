using System;

using System.Windows.Forms;

namespace SERTS_GUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void PlayButton_Click(object sender, EventArgs e)
		{
			PlayButton.Hide();
			PauseButton.Show();
		}

		private void ffButton_Click(object sender, EventArgs e)
		{

		}

		private void PauseButton_Click(object sender, EventArgs e)
		{
			PauseButton.Hide();
			PlayButton.Show();
		}
	}
}
