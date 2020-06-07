/*
 * Created by SharpDevelop.
 * User: Maryam
 * Date: 10/4/2019
 * Time: 10:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ahsan_Notpad
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
		void MainFormLoad(object sender, EventArgs e)
		{
			int w = Screen.PrimaryScreen.Bounds.Width;
			int h = Screen.PrimaryScreen.Bounds.Height;
			this.Location=new Point(0,0);
			this.Size=new Size(w,h);
		}
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
	        System.IO.File.WriteAllText("F:\\Ahsan.txt",textBox1.Text);
		}
		void LoadToolStripMenuItemClick(object sender, EventArgs e)
		{
			textBox1.Text = System.IO.File.ReadAllText("F:\\Ahsan.txt");
		}
		void ExistToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
}
}