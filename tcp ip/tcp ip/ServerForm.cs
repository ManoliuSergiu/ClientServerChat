using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace WindowsFormsApp1
{
	public partial class ServerForm : Form
	{
		SimpleTcpServer server;
		public List<string> clients= new List<string>();
		bool inc=false;
		char[] split = {'«'};
		int i = 0;
		public ServerForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			server = new SimpleTcpServer
			{
				Delimiter = 0x0a,
				StringEncoder = Encoding.UTF8
			};
			server.DataReceived += Server_DataReceived;
			server.ClientConnected += Server_ClientConnected;
		}

		private void Server_ClientConnected(object sender, System.Net.Sockets.TcpClient e)
		{
			i++;
			label3.Invoke((MethodInvoker)delegate ()
			{
				label3.Text = i+"";
			});
			inc = true;
		}

		private void Server_DataReceived(object sender, SimpleTCP.Message e)
		{
			if (new string(e.MessageString.ToCharArray(),0,e.MessageString.Length-1) == "☺GetList☺")
			{
				string a = "";
				for (int k = 0; k < clients.Count; k++)
				{
					a += clients[k] + "«";
				}
				e.Reply(a);
			}
			else
			{
				if (inc == false)
				{
					outputTxt.Invoke((MethodInvoker)delegate ()
					{
						string[] message = e.MessageString.Split(split, StringSplitOptions.RemoveEmptyEntries);
						string a = "";
						for (int i = 1; i < message.Length; i++)
						{
							a += message[i];
						}
						a = new string(a.ToCharArray(), 0, a.Length - 1);
						string msg = "<" + clients[Convert.ToInt32(message[0])] + ">: " + a;
						outputTxt.Text += (Environment.NewLine + msg);
						server.BroadcastLine(Environment.NewLine + msg);
					});
				}
				else
				{
					e.Reply((i - 1) + "«");
					outputTxt.Invoke((MethodInvoker)delegate ()
					{

						clients.Add(new string(e.MessageString.ToCharArray(), 0, e.MessageString.Length - 1));
						inc = false;
						string a = new string(e.MessageString.ToCharArray(), 0, e.MessageString.Length - 1);
						outputTxt.Text += (Environment.NewLine + a + " joined the chat.");
						server.BroadcastLine(Environment.NewLine + a + " joined the chat.");
					});
				}
			}
		}

		private void startBtn_Click(object sender, EventArgs e)
		{
			outputTxt.Text += "Server starting... ";
			System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
			server.Start(ip, Convert.ToInt32(txtPort.Text));
			outputTxt.Text += Environment.NewLine+"Server started.";

		}

		private void stopBtn_Click(object sender, EventArgs e)
		{
			if (server.IsStarted)
			{
				server.Stop();
			}
		}

		private void clientsBtn_Click(object sender, EventArgs e)
		{
			ClientList x = new ClientList(clients);
			x.Show();
		}
	}
}
