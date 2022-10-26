using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Q2 : Form
	{
		public Q2()
		{
			InitializeComponent();
			ResultLabel.Text=string.Empty;
		}

		private void CheckButton_Click(object sender, EventArgs e)
		{
			DateTime time;
			try
			{
				time = GetTime();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			Check(time);
		}

		private DateTime GetTime()
		{
			string input = InputTextBox.Text;
			bool isInt = DateTime.TryParse(input, out DateTime time);
			if (isInt == false)
			{
				throw new Exception("請輸入日期");
			}
			return time;
		}

		private string Check(DateTime checknumber)
		{
			DateTime date = checknumber;
			if (date<=DateTime.Today)
			{
				return ResultLabel.Text = ("日期不大於今天");
			}
			else
			{
				return ResultLabel.Text = ("日期大於今天");
			}
		}
	}
}
