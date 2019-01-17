namespace WindowsFormsApp1
{
	partial class ServerForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtHost = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.startBtn = new System.Windows.Forms.Button();
			this.stopBtn = new System.Windows.Forms.Button();
			this.outputTxt = new System.Windows.Forms.TextBox();
			this.clientsBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(89, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Host";
			// 
			// txtHost
			// 
			this.txtHost.Location = new System.Drawing.Point(124, 27);
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new System.Drawing.Size(100, 20);
			this.txtHost.TabIndex = 1;
			this.txtHost.Text = "127.0.0.1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(230, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Port:";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(265, 27);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(47, 20);
			this.txtPort.TabIndex = 3;
			this.txtPort.Text = "8910";
			// 
			// startBtn
			// 
			this.startBtn.Location = new System.Drawing.Point(329, 25);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(75, 23);
			this.startBtn.TabIndex = 4;
			this.startBtn.Text = "Start Server";
			this.startBtn.UseVisualStyleBackColor = true;
			this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
			// 
			// stopBtn
			// 
			this.stopBtn.Location = new System.Drawing.Point(410, 25);
			this.stopBtn.Name = "stopBtn";
			this.stopBtn.Size = new System.Drawing.Size(75, 23);
			this.stopBtn.TabIndex = 5;
			this.stopBtn.Text = "Stop Server";
			this.stopBtn.UseVisualStyleBackColor = true;
			this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
			// 
			// outputTxt
			// 
			this.outputTxt.Location = new System.Drawing.Point(80, 58);
			this.outputTxt.Multiline = true;
			this.outputTxt.Name = "outputTxt";
			this.outputTxt.ReadOnly = true;
			this.outputTxt.Size = new System.Drawing.Size(405, 172);
			this.outputTxt.TabIndex = 6;
			// 
			// clientsBtn
			// 
			this.clientsBtn.Location = new System.Drawing.Point(9, 91);
			this.clientsBtn.Name = "clientsBtn";
			this.clientsBtn.Size = new System.Drawing.Size(56, 44);
			this.clientsBtn.TabIndex = 8;
			this.clientsBtn.Text = "Client List";
			this.clientsBtn.UseVisualStyleBackColor = true;
			this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "0 Connected";
			// 
			// ServerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 256);
			this.Controls.Add(this.clientsBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.outputTxt);
			this.Controls.Add(this.stopBtn);
			this.Controls.Add(this.startBtn);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtHost);
			this.Controls.Add(this.label1);
			this.Name = "ServerForm";
			this.Text = "Server";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtHost;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Button startBtn;
		private System.Windows.Forms.Button stopBtn;
		private System.Windows.Forms.TextBox outputTxt;
		private System.Windows.Forms.Button clientsBtn;
		private System.Windows.Forms.Label label3;
	}
}

