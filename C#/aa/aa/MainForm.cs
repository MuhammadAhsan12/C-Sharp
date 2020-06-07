/*
 * Created by SharpDevelop.
 * User: Maryam
 * Date: 10/3/2019
 * Time: 10:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace aa
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
		void Click(object sender, MouseEventArgs e)
		{
	       button1.BackColor=Color.Red;
		}
		void Leave(object sender, EventArgs e)
		{
	       button1.BackColor=Color.White;
		}
		void Hover(object sender, EventArgs e)
		{
	      button1.BackColor=Color.Green;
		}
		void Button1Click(object sender, EventArgs e)
		{
			button1.=Color.Blue;
		}
	}
}
