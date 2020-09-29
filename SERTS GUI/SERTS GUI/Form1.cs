using System;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

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
			string message = "You clicked Fast Forward";
			MessageBox.Show(message);
		}

		private void PauseButton_Click(object sender, EventArgs e)
		{
			PauseButton.Hide();
			PlayButton.Show();
		}

		private void skipBackButton_Click(object sender, EventArgs e)
		{
			string message = "You clicked Skip Back Button";
			MessageBox.Show(message);
		}

		private void rwButton_Click(object sender, EventArgs e)
		{
			string message = "You clicked Rewind Button";
			MessageBox.Show(message);
		}

		private void skipForwardButton_Click(object sender, EventArgs e)
		{
			string message = "You clicked Skip Forward Button";
			MessageBox.Show(message);
		}
	}
}
