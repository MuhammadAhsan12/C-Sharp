/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 12/19/2019
 * Time: 5:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace binary_octal_haxel_converter
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
			int num = Convert.ToInt32(textBox1.Text);
			string Base = Convert.ToString(num , 2);
			textBox2.Text = Base;
		}
		void Button2Click(object sender, EventArgs e)
		{
	        int num = Convert.ToInt32(textBox1.Text);
			string Base = Convert.ToString(num , 8);
			textBox2.Text = Base;
		}
		void Button3Click(object sender, EventArgs e)
		{
            int num = Convert.ToInt32(textBox1.Text);
			string Base = Convert.ToString(num , 16);
			textBox2.Text = Base;
		}
	}
}
