using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class ClientList : Form
	{
		List<string> Clients;
		public ClientList(List<string> clientlist)
		{
			InitializeComponent();
			Clients = clientlist;
		}

		private void ClientList_Load(object sender, EventArgs e)
		{
			foreach (var item in Clients)
				listBox1.Items.Add(item);
			
		}
	}
}
