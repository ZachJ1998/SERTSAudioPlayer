namespace SERTS_GUI
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.PlayButton = new System.Windows.Forms.Button();
			this.ffButton = new System.Windows.Forms.Button();
			this.rwButton = new System.Windows.Forms.Button();
			this.skipForwardButton = new System.Windows.Forms.Button();
			this.skipBackButton = new System.Windows.Forms.Button();
			this.PauseButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.FileLoadButton = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.RepeatButton = new System.Windows.Forms.Button();
			this.ShuffleButton = new System.Windows.Forms.Button();
			this.ComListBox = new System.Windows.Forms.ListBox();
			this.ComResultTextBox = new System.Windows.Forms.TextBox();
			this.Connect = new System.Windows.Forms.Button();
			this.Disconnect = new System.Windows.Forms.Button();
			this.MyPort = new System.IO.Ports.SerialPort(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// PlayButton
			// 
			this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.PlayButton.FlatAppearance.BorderSize = 0;
			this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PlayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
			this.PlayButton.Location = new System.Drawing.Point(382, 382);
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(54, 57);
			this.PlayButton.TabIndex = 4;
			this.PlayButton.UseVisualStyleBackColor = false;
			this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
			// 
			// ffButton
			// 
			this.ffButton.FlatAppearance.BorderSize = 0;
			this.ffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ffButton.Image = ((System.Drawing.Image)(resources.GetObject("ffButton.Image")));
			this.ffButton.Location = new System.Drawing.Point(481, 382);
			this.ffButton.Name = "ffButton";
			this.ffButton.Size = new System.Drawing.Size(68, 57);
			this.ffButton.TabIndex = 5;
			this.ffButton.UseVisualStyleBackColor = true;
			this.ffButton.Click += new System.EventHandler(this.ffButton_Click);
			// 
			// rwButton
			// 
			this.rwButton.FlatAppearance.BorderSize = 0;
			this.rwButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rwButton.Image = ((System.Drawing.Image)(resources.GetObject("rwButton.Image")));
			this.rwButton.Location = new System.Drawing.Point(238, 379);
			this.rwButton.Name = "rwButton";
			this.rwButton.Size = new System.Drawing.Size(73, 57);
			this.rwButton.TabIndex = 3;
			this.rwButton.UseVisualStyleBackColor = true;
			this.rwButton.Click += new System.EventHandler(this.rwButton_Click);
			// 
			// skipForwardButton
			// 
			this.skipForwardButton.FlatAppearance.BorderSize = 0;
			this.skipForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.skipForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("skipForwardButton.Image")));
			this.skipForwardButton.Location = new System.Drawing.Point(574, 382);
			this.skipForwardButton.Name = "skipForwardButton";
			this.skipForwardButton.Size = new System.Drawing.Size(67, 57);
			this.skipForwardButton.TabIndex = 6;
			this.skipForwardButton.UseVisualStyleBackColor = true;
			this.skipForwardButton.Click += new System.EventHandler(this.skipForwardButton_Click);
			// 
			// skipBackButton
			// 
			this.skipBackButton.FlatAppearance.BorderSize = 0;
			this.skipBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.skipBackButton.Image = ((System.Drawing.Image)(resources.GetObject("skipBackButton.Image")));
			this.skipBackButton.Location = new System.Drawing.Point(169, 379);
			this.skipBackButton.Name = "skipBackButton";
			this.skipBackButton.Size = new System.Drawing.Size(63, 57);
			this.skipBackButton.TabIndex = 2;
			this.skipBackButton.UseVisualStyleBackColor = true;
			this.skipBackButton.Click += new System.EventHandler(this.skipBackButton_Click);
			// 
			// PauseButton
			// 
			this.PauseButton.FlatAppearance.BorderSize = 0;
			this.PauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PauseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
			this.PauseButton.Location = new System.Drawing.Point(382, 380);
			this.PauseButton.Name = "PauseButton";
			this.PauseButton.Size = new System.Drawing.Size(54, 55);
			this.PauseButton.TabIndex = 4;
			this.PauseButton.UseVisualStyleBackColor = true;
			this.PauseButton.Visible = false;
			this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(305, 329);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(207, 22);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "This is the song name!";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(195, -2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(390, 325);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(668, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 228);
			this.listBox1.TabIndex = 8;
			// 
			// FileLoadButton
			// 
			this.FileLoadButton.ForeColor = System.Drawing.Color.Black;
			this.FileLoadButton.Location = new System.Drawing.Point(668, 265);
			this.FileLoadButton.Name = "FileLoadButton";
			this.FileLoadButton.Size = new System.Drawing.Size(120, 23);
			this.FileLoadButton.TabIndex = 9;
			this.FileLoadButton.Text = "Load File";
			this.FileLoadButton.UseVisualStyleBackColor = true;
			this.FileLoadButton.Click += new System.EventHandler(this.FileLoadButton_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(305, 353);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(207, 23);
			this.progressBar1.TabIndex = 11;
			// 
			// RepeatButton
			// 
			this.RepeatButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.RepeatButton.FlatAppearance.BorderSize = 0;
			this.RepeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RepeatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.RepeatButton.Image = ((System.Drawing.Image)(resources.GetObject("RepeatButton.Image")));
			this.RepeatButton.Location = new System.Drawing.Point(668, 382);
			this.RepeatButton.Margin = new System.Windows.Forms.Padding(0);
			this.RepeatButton.Name = "RepeatButton";
			this.RepeatButton.Size = new System.Drawing.Size(64, 51);
			this.RepeatButton.TabIndex = 7;
			this.RepeatButton.UseVisualStyleBackColor = true;
			this.RepeatButton.Click += new System.EventHandler(this.RepeatButton_Click);
			// 
			// ShuffleButton
			// 
			this.ShuffleButton.FlatAppearance.BorderSize = 0;
			this.ShuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ShuffleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ShuffleButton.Image = ((System.Drawing.Image)(resources.GetObject("ShuffleButton.Image")));
			this.ShuffleButton.Location = new System.Drawing.Point(79, 388);
			this.ShuffleButton.Name = "ShuffleButton";
			this.ShuffleButton.Size = new System.Drawing.Size(54, 45);
			this.ShuffleButton.TabIndex = 1;
			this.ShuffleButton.UseVisualStyleBackColor = true;
			this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
			// 
			// ComListBox
			// 
			this.ComListBox.FormattingEnabled = true;
			this.ComListBox.ItemHeight = 16;
			this.ComListBox.Location = new System.Drawing.Point(13, 31);
			this.ComListBox.Name = "ComListBox";
			this.ComListBox.Size = new System.Drawing.Size(120, 84);
			this.ComListBox.TabIndex = 12;
			// 
			// ComResultTextBox
			// 
			this.ComResultTextBox.Location = new System.Drawing.Point(13, 134);
			this.ComResultTextBox.Name = "ComResultTextBox";
			this.ComResultTextBox.Size = new System.Drawing.Size(120, 22);
			this.ComResultTextBox.TabIndex = 13;
			// 
			// Connect
			// 
			this.Connect.ForeColor = System.Drawing.Color.Black;
			this.Connect.Location = new System.Drawing.Point(13, 163);
			this.Connect.Name = "Connect";
			this.Connect.Size = new System.Drawing.Size(120, 23);
			this.Connect.TabIndex = 14;
			this.Connect.Text = "Connect";
			this.Connect.UseVisualStyleBackColor = true;
			this.Connect.Click += new System.EventHandler(this.Connect_Click);
			// 
			// Disconnect
			// 
			this.Disconnect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Disconnect.Location = new System.Drawing.Point(13, 193);
			this.Disconnect.Name = "Disconnect";
			this.Disconnect.Size = new System.Drawing.Size(120, 23);
			this.Disconnect.TabIndex = 15;
			this.Disconnect.Text = "Disconnect";
			this.Disconnect.UseVisualStyleBackColor = true;
			this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Disconnect);
			this.Controls.Add(this.Connect);
			this.Controls.Add(this.ComResultTextBox);
			this.Controls.Add(this.ComListBox);
			this.Controls.Add(this.ShuffleButton);
			this.Controls.Add(this.RepeatButton);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.FileLoadButton);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.PauseButton);
			this.Controls.Add(this.skipBackButton);
			this.Controls.Add(this.skipForwardButton);
			this.Controls.Add(this.rwButton);
			this.Controls.Add(this.ffButton);
			this.Controls.Add(this.PlayButton);
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button PlayButton;
		private System.Windows.Forms.Button ffButton;
		private System.Windows.Forms.Button rwButton;
		private System.Windows.Forms.Button skipForwardButton;
		private System.Windows.Forms.Button skipBackButton;
		private System.Windows.Forms.Button PauseButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button FileLoadButton;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button RepeatButton;
		private System.Windows.Forms.Button ShuffleButton;
		private System.Windows.Forms.ListBox ComListBox;
		private System.Windows.Forms.TextBox ComResultTextBox;
		private System.Windows.Forms.Button Connect;
		private System.Windows.Forms.Button Disconnect;
		private System.IO.Ports.SerialPort MyPort;
	}
}

