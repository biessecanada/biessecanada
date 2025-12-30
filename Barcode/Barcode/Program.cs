/*
 * Created by SharpDevelop.
 * User: CA01114
 * Date: 9/27/2016
 * Time: 5:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO.Ports;
using System.Text;

namespace Barcode
{
	class Program
	{
		public static void Main(string[] args)
		{
			System.IO.Ports.SerialPort inPort = new System.IO.Ports.SerialPort("COM5");
			//if not open, open the port
   			System.IO.Ports.SerialPort outPort = new System.IO.Ports.SerialPort("COM3");
			if (outPort.IsOpen == false) //if not open, open the port
				outPort.Open();
   			if (inPort.IsOpen == false) 
				inPort.Open();
   			
			
		}
	}
}