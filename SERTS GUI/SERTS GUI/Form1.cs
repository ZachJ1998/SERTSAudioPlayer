using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
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
			
			PopulateListBox(listBox1, @"C:\Users\Zach Jones\source\repos\SERTSAudioPlayer\SERTS GUI\ListBoxFiles", "*.txt"); // This allows the user to determine 
																															 // Get the list of available com ports and put them in the list box
			string[] ports = SerialPort.GetPortNames();
			ComResultTextBox.Text = "Com port closed";
			foreach (string port in ports)
			{
				ComListBox.Items.Add(port);                                                                                                                // what file they want to upload.
			}                                                                                                            // what file they want to upload.

			progressBar1.Minimum = 0;
			
			progressBar1.Maximum = 5;

			progressBar1.Step = 1;
			// Uses a for loop to iterate through the operations to be  
			// completed. In this case, five files are to be copied into memory,  
			// so the loop will execute 5 times.  
			for (int i = 0; i <= 4; i++)
			{
				// Inserts code to copy a file  
				progressBar1.PerformStep();
				// Updates the label to show that a file was read.  
			}
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

		private void RepeatButton_Click(object sender, EventArgs e)
		{
			string message = "You clicked Repeat Button";
			MessageBox.Show(message);
		}

		private void ShuffleButton_Click(object sender, EventArgs e)
		{
			string message = "You clicked Shuffle Button";
			MessageBox.Show(message);
		}

		private void Connect_Click(object sender, EventArgs e)
		{
			// Connect to a selected serial port
			if (MyPort.IsOpen == false)
			{
				// a serial port in not already open
				if (ComListBox.SelectedItem != null/* TODO Change to default(_) if this is not a reference type */ )
				{
					// an item in the listbox has been selected
					MyPort.PortName = ComListBox.SelectedItem.ToString();

					try
					{
						// try to open the selected serial port
						MyPort.Open();
					}
					catch
					{
						Debug.WriteLine("Failed to open serial port");
					}
					if (MyPort.IsOpen)
						// The serial port was opened
						ComResultTextBox.Text = "Com port " + MyPort.PortName + " connected";
					else
						// The serial port open failed
						ComResultTextBox.Text = "Com port " + MyPort.PortName + " not connected";
				}
				else
					ComResultTextBox.Text = "Nothing selected";
			}
			else
				// A com port is already open
				ComResultTextBox.Text = "Com port " + MyPort.PortName + " already connected";
		}

		private void Disconnect_Click(object sender, EventArgs e)
		{
			// Close the serial port if it is open
			if (MyPort.IsOpen)
			{
				MyPort.Close();
				ComResultTextBox.Text = "Com port closed";
			}
		}
	}

}



