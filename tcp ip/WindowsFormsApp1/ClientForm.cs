using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class ClientForm : Form
	{
		SimpleTcpClient client;
		int id=0;
		char[] split = { '«' };//alt-174
		bool gettingid = false;
		List<string> clients= new List<string>();
		bool gettinglist = false;
		public ClientForm()
		{
			InitializeComponent();
		}

		private void Connect_Click(object sender, EventArgs e)
		{
			ConnectBtn.Enabled = false;
			client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
			gettingid = true;
			client.WriteLine(txtUser.Text);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			client = new SimpleTcpClient();
			client.Delimiter = 0x0a;
			client.StringEncoder = Encoding.UTF8;
			client.DataReceived += client_DataReceived;
		}

		private void client_DataReceived(object sender, SimpleTCP.Message e)
		{
			string[] message = e.MessageString.Split(split,StringSplitOptions.RemoveEmptyEntries);
			if (gettinglist)
			{
				clients = message.ToList();
				gettinglist = false;
			}
			else
			{
				if (gettingid)
				{
					id = Convert.ToInt32(message[0]);
					gettingid = false;
				}
				else
					outputTxt.Invoke((MethodInvoker)delegate ()
					{
						outputTxt.Text += e.MessageString;
					});
			}
		}

		private void sendBtn_Click(object sender, EventArgs e)
		{
			if (inputTxt.Text != "")
			{
				client.WriteLine(id+"«" + inputTxt.Text);
				inputTxt.Text = "";
			}
		}

		private void inputTxt_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (inputTxt.Text != "")
				{
					string aux = new string(inputTxt.Text.ToCharArray(),0, inputTxt.Text.Length - 2);
					client.WriteLine(id + "«" + inputTxt.Text);
					inputTxt.Text = "";
				}
			}
		}

		private void clientsBtn_Click(object sender, EventArgs e)
		{
			gettinglist = true;
			client.WriteLine("☺GetList☺");
			Thread.Sleep(50);
			ClientList x = new ClientList(clients);
			x.Show();
		}
	}
}
