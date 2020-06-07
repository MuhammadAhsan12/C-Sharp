/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 8/25/2019
 * Time: 3:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
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
			Double a,b,c;
			a=Convert.ToDouble(textBox1.Text);
			b=Convert.ToDouble(textBox2.Text);
			c=a+b;
			label3.Text=c.ToString();
		}
		void Button2Click(object sender, EventArgs e)
		{
	        Double a,b,c;
			a=Convert.ToDouble(textBox1.Text);
			b=Convert.ToDouble(textBox2.Text);
			c=a-b;
			label3.Text=c.ToString();
		}
		void Button3Click(object sender, EventArgs e)
		{
	        Double a,b,c;
			a=Convert.ToDouble(textBox1.Text);
			b=Convert.ToDouble(textBox2.Text);
			c=a*b;
			label3.Text=c.ToString();
		}
		void Button4Click(object sender, EventArgs e)
		{
	        Double a,b,c;
			a=Convert.ToDouble(textBox1.Text);
			b=Convert.ToDouble(textBox2.Text);
			c=a/b;
			label3.Text=c.ToString();
		}
	}
}
