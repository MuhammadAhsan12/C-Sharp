/*
 * Created by SharpDevelop.
 * User: Maryam
 * Date: 10/4/2019
 * Time: 11:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Notpad
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
			System.IO.File.WriteAllText("F:\\Ahsan.txt",textBox1.Text);
		}
		void Button2Click(object sender, EventArgs e)
		{
	        textBox1.Text = System.IO.File.ReadAllText("F:\\Ahsan.txt");
		}
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text="";
		}
		void Button4Click(object sender, EventArgs e)
		{
			Font a;
			fontDialog1.ShowDialog();
			a = fontDialog1.Font;
			textBox1.Font = a;
		}
		void Button5Click(object sender, EventArgs e)
		{
	        Color a;
	        colorDialog1.ShowDialog();
			a = fontDialog1.Color;
			textBox1.BackColor = a;
		}
		void Button6Click(object sender, EventArgs e)
		{
	        Color a;
	        colorDialog1.ShowDialog();
			a = fontDialog1.Color;
			textBox1.ForeColor = a;
		}
		void Button7Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
