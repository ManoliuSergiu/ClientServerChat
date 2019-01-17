namespace WindowsFormsApp1
{
	partial class ClientForm
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
			this.ConnectBtn = new System.Windows.Forms.Button();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtHost = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.inputTxt = new System.Windows.Forms.TextBox();
			this.sendBtn = new System.Windows.Forms.Button();
			this.outputTxt = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.clientsBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ConnectBtn
			// 
			this.ConnectBtn.Location = new System.Drawing.Point(304, 31);
			this.ConnectBtn.Name = "ConnectBtn";
			this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
			this.ConnectBtn.TabIndex = 10;
			this.ConnectBtn.Text = "Connect";
			this.ConnectBtn.UseVisualStyleBackColor = true;
			this.ConnectBtn.Click += new System.EventHandler(this.Connect_Click);
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(240, 33);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(47, 20);
			this.txtPort.TabIndex = 9;
			this.txtPort.Text = "8910";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(205, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Port:";
			// 
			// txtHost
			// 
			this.txtHost.Location = new System.Drawing.Point(84, 33);
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new System.Drawing.Size(100, 20);
			this.txtHost.TabIndex = 7;
			this.txtHost.Text = "127.0.0.1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Host";
			// 
			// inputTxt
			// 
			this.inputTxt.Location = new System.Drawing.Point(55, 291);
			this.inputTxt.Multiline = true;
			this.inputTxt.Name = "inputTxt";
			this.inputTxt.Size = new System.Drawing.Size(324, 56);
			this.inputTxt.TabIndex = 12;
			this.inputTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputTxt_KeyUp);
			// 
			// sendBtn
			// 
			this.sendBtn.Location = new System.Drawing.Point(385, 291);
			this.sendBtn.Name = "sendBtn";
			this.sendBtn.Size = new System.Drawing.Size(61, 56);
			this.sendBtn.TabIndex = 13;
			this.sendBtn.Text = "Send";
			this.sendBtn.UseVisualStyleBackColor = true;
			this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
			// 
			// outputTxt
			// 
			this.outputTxt.BackColor = System.Drawing.SystemColors.ControlDark;
			this.outputTxt.Location = new System.Drawing.Point(55, 59);
			this.outputTxt.Multiline = true;
			this.outputTxt.Name = "outputTxt";
			this.outputTxt.ReadOnly = true;
			this.outputTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.outputTxt.Size = new System.Drawing.Size(324, 226);
			this.outputTxt.TabIndex = 14;
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(84, 7);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(100, 20);
			this.txtUser.TabIndex = 15;
			this.txtUser.Text = "User";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Name";
			// 
			// clientsBtn
			// 
			this.clientsBtn.Location = new System.Drawing.Point(385, 59);
			this.clientsBtn.Name = "clientsBtn";
			this.clientsBtn.Size = new System.Drawing.Size(61, 47);
			this.clientsBtn.TabIndex = 17;
			this.clientsBtn.Text = "Client List";
			this.clientsBtn.UseVisualStyleBackColor = true;
			this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 364);
			this.Controls.Add(this.clientsBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.outputTxt);
			this.Controls.Add(this.sendBtn);
			this.Controls.Add(this.inputTxt);
			this.Controls.Add(this.ConnectBtn);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtHost);
			this.Controls.Add(this.label1);
			this.Name = "ClientForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button ConnectBtn;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtHost;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputTxt;
		private System.Windows.Forms.Button sendBtn;
		private System.Windows.Forms.TextBox outputTxt;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button clientsBtn;
	}
}

