/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 8/16/2019
 * Time: 12:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace File_creat
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a;
			FileStream fs = new FileStream(@"C:\Users\Ahsan\Desktop\ahsan.txt", FileMode.Create);
			BinaryWriter bw =new BinaryWriter(fs);
			a=Convert.ToInt32(Console.ReadLine());
			while (a>0) {
			bw.Write(a);
			a=Convert.ToInt32(Console.ReadLine());
			}
            fs.Close();
            bw.Close();
            
            Console.ReadKey();
			
		}
	}
}