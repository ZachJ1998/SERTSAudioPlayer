using System;
using System.Diagnostics;
using System.IO;
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
			PopulateListBox(listBox1, @"C:\Users\Zach Jones\source\repos\SERTSAudioPlayer\SERTS GUI\ListBoxFiles", "*.txt");
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

		private void FileLoadButton_Click(object sender, EventArgs e)
		{
			
			string fileName = listBox1.SelectedItem.ToString();
			//Process.Start(@"C:\\Users\\Zach Jones\\source\\repos\\SERTSAudioPlayer\\SERTS GUI\\ListBoxFile\\" + fileName);
			MessageBox.Show("You clicked: " + fileName);
		}

		private void PopulateListBox(ListBox lsb, string Folder, string FileType)
		{
			DirectoryInfo dinfo = new DirectoryInfo(Folder);
			FileInfo[] Files = dinfo.GetFiles(FileType);
			foreach (FileInfo file in Files)
			{
				lsb.Items.Add(file.Name);
			}
		}
	}
}

//insert listBox for file
// button to load file list
