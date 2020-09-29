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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.PlayButton = new System.Windows.Forms.Button();
			this.ffButton = new System.Windows.Forms.Button();
			this.rwButton = new System.Windows.Forms.Button();
			this.skipForwardButton = new System.Windows.Forms.Button();
			this.skipBackButton = new System.Windows.Forms.Button();
			this.PauseButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// PlayButton
			// 
			this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.PlayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
			this.PlayButton.Location = new System.Drawing.Point(384, 381);
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(54, 57);
			this.PlayButton.TabIndex = 0;
			this.PlayButton.UseVisualStyleBackColor = false;
			this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
			// 
			// ffButton
			// 
			this.ffButton.Image = ((System.Drawing.Image)(resources.GetObject("ffButton.Image")));
			this.ffButton.Location = new System.Drawing.Point(444, 381);
			this.ffButton.Name = "ffButton";
			this.ffButton.Size = new System.Drawing.Size(68, 57);
			this.ffButton.TabIndex = 1;
			this.ffButton.UseVisualStyleBackColor = true;
			this.ffButton.Click += new System.EventHandler(this.ffButton_Click);
			// 
			// rwButton
			// 
			this.rwButton.Image = ((System.Drawing.Image)(resources.GetObject("rwButton.Image")));
			this.rwButton.Location = new System.Drawing.Point(305, 381);
			this.rwButton.Name = "rwButton";
			this.rwButton.Size = new System.Drawing.Size(73, 57);
			this.rwButton.TabIndex = 2;
			this.rwButton.UseVisualStyleBackColor = true;
			this.rwButton.Click += new System.EventHandler(this.rwButton_Click);
			// 
			// skipForwardButton
			// 
			this.skipForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("skipForwardButton.Image")));
			this.skipForwardButton.Location = new System.Drawing.Point(518, 381);
			this.skipForwardButton.Name = "skipForwardButton";
			this.skipForwardButton.Size = new System.Drawing.Size(67, 57);
			this.skipForwardButton.TabIndex = 3;
			this.skipForwardButton.UseVisualStyleBackColor = true;
			this.skipForwardButton.Click += new System.EventHandler(this.skipForwardButton_Click);
			// 
			// skipBackButton
			// 
			this.skipBackButton.Image = ((System.Drawing.Image)(resources.GetObject("skipBackButton.Image")));
			this.skipBackButton.Location = new System.Drawing.Point(236, 381);
			this.skipBackButton.Name = "skipBackButton";
			this.skipBackButton.Size = new System.Drawing.Size(63, 57);
			this.skipBackButton.TabIndex = 4;
			this.skipBackButton.UseVisualStyleBackColor = true;
			this.skipBackButton.Click += new System.EventHandler(this.skipBackButton_Click);
			// 
			// PauseButton
			// 
			this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
			this.PauseButton.Location = new System.Drawing.Point(384, 382);
			this.PauseButton.Name = "PauseButton";
			this.PauseButton.Size = new System.Drawing.Size(54, 55);
			this.PauseButton.TabIndex = 5;
			this.PauseButton.UseVisualStyleBackColor = true;
			this.PauseButton.Visible = false;
			this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(270, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(300, 297);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(305, 329);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(207, 22);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "This is the song name!";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox1);
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox1;
	}
}

