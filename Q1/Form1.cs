using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Q1 : Form
	{
		public Q1()
		{
			InitializeComponent();
			ResultLabel.Text=string.Empty;
		}

		private void CheckButton_Click(object sender, EventArgs e)
		{
			int number ;
			try
			{
				number = GetNumber();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			Check(number);

			
		}

		private string Check(int checknumber)
		{
			int number = checknumber;
			if (number < 1 || number > 99)
			{
				return ResultLabel.Text= ("數字不在1~99之間");
			}
			else
			{
				return ResultLabel.Text = ("數字在範圍內");
			}
		}

		private int GetNumber()
		{
			string input = InputTextBox.Text;
			bool isInt = int.TryParse(input, out int number);
			if (isInt == false)
			{
				throw new Exception("請輸入數字");
			}
			return number;
		}
	}
}
