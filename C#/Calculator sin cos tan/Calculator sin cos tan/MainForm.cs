/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 9/2/2019
 * Time: 8:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator_sin_cos_tan
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
			textBox1.Text="";
		}
		void Button4Click(object sender, EventArgs e)
		{
			textBox1.Text=textBox1.Text + "1";
		}
		void Button5Click(object sender, EventArgs e)
		{
			Double X;
			X=Convert.ToDouble(Math.Sin(textBox1.Text));
			
			
			textBox1.Text=X.ToString();
		}
	}
}
