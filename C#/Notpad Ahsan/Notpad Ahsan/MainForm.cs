/*
 * Created by SharpDevelop.
 * User: Maryam
 * Date: 10/7/2019
 * Time: 8:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Notpad_Ahsan
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
		void AboutNotpadToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("All right reserved with the auther","About Notpad Xp",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		void NewToolStripMenuItemClick(object sender, EventArgs e)
		{
			textBox1.Text=("");
		}
		void ExistToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
