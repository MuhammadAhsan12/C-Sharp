/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 12/19/2019
 * Time: 4:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace integer_series
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
			double a = Convert.ToDouble(textBox1.Text);
			double b = Convert.ToDouble(textBox2.Text);
		    for (double i = a; i <= b ; i++)
		    {
		    	for (double j = a ; j <= b; j++) 
		    	{
		    		break;
		    	}
		    	listBox1.Items.Add(i);
		    }
		   
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
	}
}
