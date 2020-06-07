/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 10/17/2019
 * Time: 8:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pic_editor
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		//for Negative;
		
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
					int A = c.A;
					R = 255 - R;
					G = 255 - G;
					B = 255 - B;
					A = 255 - A;
					b1.SetPixel(x,y,Color.FromArgb(R,G,B,A));
				}
				pictureBox2.Image=b1;
			}
		}
		
		//For Bluring;
		
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
					int avg = R + G + B/3;
					avg = R;
					avg = G;
					avg = B;
					b1.SetPixel(x,y,Color.FromArgb(avg,avg,avg,avg));
				}
				pictureBox2.Image=b1;
			}
		}
		void Button3Click(object sender, EventArgs e)
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
