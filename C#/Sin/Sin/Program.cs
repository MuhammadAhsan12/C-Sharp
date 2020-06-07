/*
 * Created by SharpDevelop.
 * User: Ahsan
 * Date: 11/1/2019
 * Time: 9:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Sin
{
	class Program
	{
		public static void Main(string[] args)
		{
	        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("case {0}:", i);
            Console.WriteLine("    return {0};", Math.Sin(i));
        }
	        double a = Convert.ToDouble(Console.ReadLine());
	        Console.WriteLine("    return {0};", Math.Sin(a));
	        Console.WriteLine(a);
	        Console.ReadLine();
		}
	}
}