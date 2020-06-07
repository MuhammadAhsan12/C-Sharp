/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 12/19/2019
 * Time: 12:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace recursion_fact
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			fact();
		}
		void fact()
		{
			int n = Convert.ToInt32(textBox1.Text);
			int f = 1;
			for (int i = 1; i <= n; i++) 
			{
				f = f * i;
			}
			textBox2.Text=f.ToString();
		}
	}
}
