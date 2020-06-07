/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 8/14/2019
 * Time: 11:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace File_Stream
{
	class Program
	{
		public static void Main(string[] args)
		{
			File_Stream fs=new File_Stream(@"C:\Users\Ahsan\Desktop\file\Ahsan.txt",FileMode.OpenOrCreate);
			BinaryWriter bw=new BinaryWriter (fs);
			Console.WriteLine("Enter the txt");
			int S;
			while (S>0) {
				bw.Write(S);
				S=Convert.ToInt32(Console.ReadLine());
			}
			S=Convert.ToInt32(Console.WriteLine());
			bw.Close();
			fs.Close();
			
		}
	}
}