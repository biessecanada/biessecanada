/*
 */
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WTMZONA
{
	class Program
	{
		public static void Main(string[] args)
		{
			// TODO: Implement Functionality Here
			string[] lines = File.ReadAllLines("C:\\WNC\\home\\d_xnc\\dati\\data\\oem_wtmzona.dat.ini", Encoding.UTF8);
			int[][] WTMZONAARRAY = new int[51][];
			int counter=-1;
			bool consider=false;
			bool WTMZONA = false;
			string[] words;
			WTMZONAARRAY[0] = new int[5];
			WTMZONAARRAY[1] = new int[5];
			WTMZONAARRAY[2] = new int[5];
			WTMZONAARRAY[3] = new int[5];
			WTMZONAARRAY[4] = new int[5];
			WTMZONAARRAY[5] = new int[5];
			WTMZONAARRAY[6] = new int[5];
			WTMZONAARRAY[7] = new int[5];
			WTMZONAARRAY[8] = new int[5];
			WTMZONAARRAY[9] = new int[5];
			WTMZONAARRAY[10] = new int[5];
			WTMZONAARRAY[11] = new int[5];
			WTMZONAARRAY[12] = new int[5];
			WTMZONAARRAY[13] = new int[5];
			WTMZONAARRAY[14] = new int[5];
			WTMZONAARRAY[15] = new int[5];
			WTMZONAARRAY[16] = new int[5];
			WTMZONAARRAY[17] = new int[5];
			WTMZONAARRAY[18] = new int[5];
			WTMZONAARRAY[19] = new int[5];
			WTMZONAARRAY[20] = new int[5];
			WTMZONAARRAY[21] = new int[5];
			WTMZONAARRAY[22] = new int[5];
			WTMZONAARRAY[23] = new int[5];
			WTMZONAARRAY[24] = new int[5];
			WTMZONAARRAY[25] = new int[5];
			WTMZONAARRAY[26] = new int[5];
			WTMZONAARRAY[27] = new int[5];
			WTMZONAARRAY[28] = new int[5];
			WTMZONAARRAY[29] = new int[5];
			WTMZONAARRAY[30] = new int[5];
			WTMZONAARRAY[31] = new int[5];
			WTMZONAARRAY[32] = new int[5];
			WTMZONAARRAY[33] = new int[5];
			WTMZONAARRAY[34] = new int[5];
			WTMZONAARRAY[35] = new int[5];
			WTMZONAARRAY[36] = new int[5];
			WTMZONAARRAY[37] = new int[5];
			WTMZONAARRAY[38] = new int[5];
			WTMZONAARRAY[39] = new int[5];
			WTMZONAARRAY[40] = new int[5];
			WTMZONAARRAY[41] = new int[5];
			using (StreamWriter file = new StreamWriter("ZONES.dxf")) {
				file.WriteLine("  0");
				file.WriteLine("SECTION");
				file.WriteLine("  2");
				file.WriteLine("ENTITIES");
				file.WriteLine("  0");
				foreach (string line in lines) {
					//string[] words = line.Split(',');
					if (line.Contains("WTMZONA")) {
						WTMZONA=!WTMZONA;
						consider=false;
						
					}
					if(WTMZONA){
						if(line.Contains("Abil=1")){
							consider=true;
							counter=counter+1;
							WTMZONAARRAY[counter][0]=1;
						}
						if(line.Contains("Xp1=") && consider){
							words = line.Split('=');
							words = words[1].Split('.');
							WTMZONAARRAY[counter][1]=System.Convert.ToInt32(words[0]);
						}
						if(line.Contains("Yp1=") && consider){
							words = line.Split('=');
							words = words[1].Split('.');
							WTMZONAARRAY[counter][2]=System.Convert.ToInt32(words[0]);
						}
						if(line.Contains("Xp2=") && consider){
							words = line.Split('=');
							words = words[1].Split('.');
							WTMZONAARRAY[counter][3]=System.Convert.ToInt32(words[0]);
						}
						if(line.Contains("Yp2=") && consider){
							words = line.Split('=');
							words = words[1].Split('.');
							WTMZONAARRAY[counter][4]=System.Convert.ToInt32(words[0]);
							WTMZONA=false;
						}
					}
					//Console.WriteLine(WTMZONA);
					//	file.WriteLine("    <ProgramWorklistItem File=\"C:/WNC/home/d_xnc/p_p/prog/" + words[1] + "\" Quantity=\"" + words[2] + "\" Counter=\"" + words[3] + "\" ExecutionTime=\"--:--:--\" IsExecutionTimeDirty=\"false\" HashCode=\"\" Description=\"\" OriginId=\"-1\" Id=\"" + Guid.NewGuid() + "\" Label=\"" + words[0] + "\">");
					//	file.WriteLine("    </ProgramWorklistItem>");
					//	}

				}
				for (int i = 0; i <= counter; i++)
				{
					file.WriteLine("POLYLINE");
					file.WriteLine("  8");
					file.WriteLine("Layer 0");
					file.WriteLine(" 62");
					file.WriteLine("255");
					file.WriteLine(" 66");
					file.WriteLine("1");
					file.WriteLine(" 70");
					file.WriteLine("     9");
					file.WriteLine(" 10");
					file.WriteLine(WTMZONAARRAY[i][1] + ".0000000000000");
					file.WriteLine(" 20");
					file.WriteLine(WTMZONAARRAY[i][2] + ".0000000000000");
					file.WriteLine(" 30");
					file.WriteLine("0.0000000000000");
					file.WriteLine("  0");
					file.WriteLine("VERTEX");
					file.WriteLine("  8");
					file.WriteLine("Layer 0");
					file.WriteLine(" 62");
					file.WriteLine("255");
					file.WriteLine(" 10");
					file.WriteLine(WTMZONAARRAY[i][1] + ".0000000000000");
					file.WriteLine(" 20");
					file.WriteLine(WTMZONAARRAY[i][2] + ".0000000000000");
					file.WriteLine(" 30");
					file.WriteLine("0.0000000000000");
					file.WriteLine(" 70");
					file.WriteLine("     32");
					file.WriteLine("  0");
					file.WriteLine("VERTEX");
					file.WriteLine("  8");
					file.WriteLine("Layer 0");
					file.WriteLine(" 62");
					file.WriteLine("255");
					file.WriteLine(" 10");
					file.WriteLine(WTMZONAARRAY[i][1] + ".0000000000000");
					file.WriteLine(" 20");
					file.WriteLine(WTMZONAARRAY[i][4] + ".0000000000000");
					file.WriteLine(" 30");
					file.WriteLine("0.0000000000000");
					file.WriteLine(" 70");
					file.WriteLine("     32");
					file.WriteLine("  0");
					file.WriteLine("VERTEX");
					file.WriteLine("  8");
					file.WriteLine("Layer 0");
					file.WriteLine(" 62");
					file.WriteLine("255");
					file.WriteLine(" 10");
					file.WriteLine(WTMZONAARRAY[i][3] + ".0000000000000");
					file.WriteLine(" 20");
					file.WriteLine(WTMZONAARRAY[i][4] + ".0000000000000");
					file.WriteLine(" 30");
					file.WriteLine("0.0000000000000");
					file.WriteLine(" 70");
					file.WriteLine("     32");
					file.WriteLine("  0");
					file.WriteLine("VERTEX");
					file.WriteLine("  8");
					file.WriteLine("Layer 0");
					file.WriteLine(" 62");
					file.WriteLine("255");
					file.WriteLine(" 10");
					file.WriteLine(WTMZONAARRAY[i][3] + ".0000000000000");
					file.WriteLine(" 20");
					file.WriteLine(WTMZONAARRAY[i][2] + ".0000000000000");
					file.WriteLine(" 30");
					file.WriteLine("0.0000000000000");
					file.WriteLine(" 70");
					file.WriteLine("     32");
					file.WriteLine("  0");
					file.WriteLine("VERTEX");
					file.WriteLine("  8");
					file.WriteLine("Layer 0");
					file.WriteLine(" 62");
					file.WriteLine("255");
					file.WriteLine(" 10");
					file.WriteLine(WTMZONAARRAY[i][1] + ".0000000000000");
					file.WriteLine(" 20");
					file.WriteLine(WTMZONAARRAY[i][2] + ".0000000000000");
					file.WriteLine(" 30");
					file.WriteLine("0.0000000000000");
					file.WriteLine(" 70");
					file.WriteLine("     32");
					file.WriteLine("  0");
					file.WriteLine("SEQEND");
					file.WriteLine("  0");
				}


				file.WriteLine("ENDSEC");
				file.WriteLine("  0");
				file.WriteLine("EOF");
			}

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}