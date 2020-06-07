/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 12/19/2019
 * Time: 7:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace factorial_recursion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			int number = Convert.ToInt32(textBox1.Text);
			factorial(number);
		}
		void factorial(int number)
		{
			if (number==0) 
			{
				return 1;
			}
			for (int i = 1; i <= number; i++) 
			{
				factorial = factorial * i;
			}
			Return (factorial);
		}
	}
}
