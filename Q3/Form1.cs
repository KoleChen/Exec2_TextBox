using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Q3 : Form
	{
		public Q3()
		{
			InitializeComponent();
			ResultLabel.Text=String.Empty;
		}

		private void CheckButton_Click(object sender, EventArgs e)
		{
			DateTime time;
			DateTime now=DateTime.Now;
			try
			{
				time = GetTime();
			}
			catch (Exception ex)
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
				throw new Exception("請輸入生日");
			}
			return time;
		}

		private string Check(DateTime time)
		{
			DateTime now = DateTime.Now;
			DateTime birthday = time;
			if(birthday>now)
			{
				return ResultLabel.Text=("生日不可大於今天");
			}
			int year = now.Year-birthday.Year;

			if (year>=13)
			{
				return ResultLabel.Text = ("已滿13歲");
			}
			else
			{
				return ResultLabel.Text = ("未滿13歲");
			}
		}
	}
}
