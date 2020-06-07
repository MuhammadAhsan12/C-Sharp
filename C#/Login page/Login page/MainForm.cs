/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 9/2/2019
 * Time: 10:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login_page
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
	if (textBox1.Text=="" && textBox2.Text=="")
	{
		MessageBox.Show("Please enter user name and pasward");
	}
	else
		if (textBox1.Text=="Ahsan" && textBox2.Text=="Ahsan") 
	{
			MessageBox.Show("You are successful log in");
		}
	else
	{
		MessageBox.Show("User name and pasward is incorrect");
	}
		}
	}
}
