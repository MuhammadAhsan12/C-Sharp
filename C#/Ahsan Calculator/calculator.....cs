/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 8/25/2019
 * Time: 5:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ahsan_Calculator
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
		String p;
		String num1;
		void Button11Click(object sender, EventArgs e)
		{
			if (textBox1.Text=="+")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="-")
			{
				textBox1.Text="";
			}	
			if (textBox1.Text=="x")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="/")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="%")
			{
				textBox1.Text="";
			}
			textBox1.Text=textBox1.Text + "1";
		}
		void Button12Click(object sender, EventArgs e)
		{
			
			if (textBox1.Text=="+")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="-")
			{
				textBox1.Text="";
			}	
			if (textBox1.Text=="x")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="/")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="%")
			{
				textBox1.Text="";
			}
	        textBox1.Text=textBox1.Text + "2";
		}
		void Button13Click(object sender, EventArgs e)
		{
			
			if (textBox1.Text=="+")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="-")
			{
				textBox1.Text="";
			}	
			if (textBox1.Text=="x")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="/")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="%")
			{
				textBox1.Text="";
			}
	        textBox1.Text=textBox1.Text + "3";
		}
		void Button6Click(object sender, EventArgs e)
		{
			if (textBox1.Text=="+")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="-")
			{
				textBox1.Text="";
			}	
			if (textBox1.Text=="x")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="/")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="%")
			{
				textBox1.Text="";
			}
	        textBox1.Text=textBox1.Text + "4";
		}
		void Button7Click(object sender, EventArgs e)
		{
			if (textBox1.Text=="+")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="-")
			{
				textBox1.Text="";
			}	
			if (textBox1.Text=="x")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="/")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="%")
			{
				textBox1.Text="";
			}
	        textBox1.Text=textBox1.Text + "5";
		}
		void Button8Click(object sender, EventArgs e)
		{
			if (textBox1.Text=="+")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="-")
			{
				textBox1.Text="";
			}	
			if (textBox1.Text=="x")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="/")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="%")
			{
				textBox1.Text="";
			}
	        textBox1.Text=textBox1.Text + "6";
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.Text=="+")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="-")
			{
				textBox1.Text="";
			}	
			if (textBox1.Text=="x")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="/")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="%")
			{
				textBox1.Text="";
			}
	        textBox1.Text=textBox1.Text + "7";
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (textBox1.Text=="+")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="-")
			{
				textBox1.Text="";
			}	
			if (textBox1.Text=="x")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="/")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="%")
			{
				textBox1.Text="";
			}
	        textBox1.Text=textBox1.Text + "8";
		}
		void Button3Click(object sender, EventArgs e)
		{
			if (textBox1.Text=="+")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="-")
			{
				textBox1.Text="";
			}	
			if (textBox1.Text=="x")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="/")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="%")
			{
				textBox1.Text="";
			}
	        textBox1.Text=textBox1.Text + "9";
		}
		void Button16Click(object sender, EventArgs e)
		{
			if (textBox1.Text=="+")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="-")
			{
				textBox1.Text="";
			}	
			if (textBox1.Text=="x")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="/")
			{
				textBox1.Text="";
			}
			if (textBox1.Text=="%")
			{
				textBox1.Text="";
			}
	        textBox1.Text=textBox1.Text + "0";
		}
		void Button17Click(object sender, EventArgs e)
		{
	        textBox1.Text=textBox1.Text + ".";
		}
		void Button14Click(object sender, EventArgs e)
		{
			p ="+";
			num1=textBox1.Text;
			textBox1.Text="+";
		}
		void Button18Click(object sender, EventArgs e)
		{
			p="-";
	        num1=textBox1.Text;
			textBox1.Text="-";
		}
		void Button9Click(object sender, EventArgs e)
		{
			p="x";
	        num1=textBox1.Text;
			textBox1.Text="x";
		}
		void Button4Click(object sender, EventArgs e)
		{
			p="/";
	        num1=textBox1.Text;
			textBox1.Text="/";
		}
		void Button5Click(object sender, EventArgs e)
		{
	        p ="n^2";
			num1=textBox1.Text;
			textBox1.Text=textBox1.Text;
		}
		void Button19Click(object sender, EventArgs e)
		{
	        p="%";
	        num1=textBox1.Text;
			textBox1.Text="%";
		}
		void Button15Click(object sender, EventArgs e)
		{
			Double S;
			if (p=="+") 
			{
			S=Convert.ToDouble(num1)+Convert.ToDouble(textBox1.Text);
			textBox1.Text=S.ToString();
			}
			if (p=="-") 
			{
			S=Convert.ToDouble(num1)-Convert.ToDouble(textBox1.Text);
			textBox1.Text=S.ToString();
			}
			if (p=="x") 
			{
			S=Convert.ToDouble(num1)*Convert.ToDouble(textBox1.Text);
			textBox1.Text=S.ToString();
			}
			if (p=="/") 
			{
			S=Convert.ToDouble(num1)/Convert.ToDouble(textBox1.Text);
			textBox1.Text=S.ToString();
			}
			if (p=="n^2") 
			{
				S=Convert.ToDouble(num1)*Convert.ToDouble(textBox1.Text);
			    textBox1.Text=S.ToString();
			}
			if (p=="%") 
			{
				S=(Convert.ToDouble(num1)/Convert.ToDouble(textBox1.Text))*100;
				textBox1.Text=S.ToString();
				textBox1.Text=textBox1.Text+"%";
			}
		}
		void Button10Click(object sender, EventArgs e)
		{
			textBox1.Text="";
		}
	}
}
