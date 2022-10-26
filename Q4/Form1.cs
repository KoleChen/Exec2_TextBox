using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Q4 : Form
	{
		public Q4()
		{
			InitializeComponent();
			PeopleLabel.Text=String.Empty;
			CarLabel.Text=String.Empty;
		}

		private void CalButton_Click(object sender, EventArgs e)
		{
			int people, car;
			try
			{
				TextBox value = PeopleTextBox;
				people = GetNumber(value);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			try
			{
				TextBox value = CarTextBox;
				car = GetNumber(value);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			PeopleExpense(people);
			CarExpense(car);
		}

		private string PeopleExpense(int people)
		{
			int peopleresult = people * 60;
			return PeopleLabel.Text = $"以人數計算要{peopleresult}元";
		}

		private string CarExpense(int car)
		{
			int carresult = car * 200;
			return CarLabel.Text = $"以車輛計算要{carresult}元";
		}

		private int GetNumber(TextBox value)
		{
			
			string input = value.Text;
			bool isInt = int.TryParse(input, out int number);
			if (isInt == false)
			{
				throw new Exception("請輸入數字");
			}
			else if(isInt == true&&number<0)
			{
				throw new Exception("數字不能為負數");
			}
			return number;
		}
	}
}
