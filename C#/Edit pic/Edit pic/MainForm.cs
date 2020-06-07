/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 10/18/2019
 * Time: 10:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Edit_pic
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
	        Bitmap b1 = new Bitmap(pictureBox1.Image);
			Color c;
			int height = b1.Height;
			int width = b1.Width;
			
			for (int y = 0; y < height; y++) 
			{
				for (int x = 0; x < width; x++)
				{
					c = b1.GetPixel(x,y);
					int R = c.R;
					int G = c.G;
					int B = c.B;
					R = 255 - R;
					G = 255 - G;
					B = 255 - B;
					b1.SetPixel(x,y,Color.FromArgb(R,G,B));
				}
				pictureBox2.Image=b1;
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
	Bitmap b1 = new Bitmap(pictureBox1.Image);
			Color c;
			int height = b1.Height;
			int width = b1.Width;
			
			for (int y = 0; y < height; y++) 
			{
				for (int x = 0; x < width; x++)
				{
					c = b1.GetPixel(x,y);
					int R = c.R;
					int G = c.G;
					int B = c.B;
					R = 255 - R;
					G = 255 - G;
					B = 255 - B;
					b1.SetPixel(x,y,Color.FromArgb(R,G,B));
				}
				pictureBox2.Image=b1;
			}
		}
	}
}
