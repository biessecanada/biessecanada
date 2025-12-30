using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace bSolidWorkingList
{
	class Program
	{
		static int OriginbSolid(string origin_albatros)
		{
			switch (origin_albatros) {
				case "S":
					return 1;
				case "N":
					return 1;
				case "S1":
					return 5;
				case "N1":
					return 5;
				case "R":
					return 4;
				case "R1":
					return 8;
				default:
					return -1;
			}
		}
		static void Main(string[] args)
		{
			//Continuous Frame Countour and Route for glass Programs;
			string[] continuous1 = { "F-DF-L", "F-DF-R", "F-D-L", "F-D-R" };
			//Continuous Path Door and DrawerFront;
			string[] continuous2 = { "DF-L", "DF-R", "D-L", "D-R" };
			//Continuous Path Mitre;
			string[] continuous3 = { "M-L", "M-R" };
			//Continuous Path Slab Programs;
			string[] continuous4 = { "S-DF-L", "S-DF-R", "S-D-L", "S-D-R" };
			//Discontinuous Door and DrawerFront;
			string[] discontinuous1 = { "O-DF-L", "O-DF-R", "O-D-L", "O-D-R" };
			//Discontinuous Mitre;
			string[] discontinuous2 = { "O-M-L", "O-M-R" };
			//Discontinuous Slab;
			string[] discontinuous3 = { "O-S-DF-L", "O-S-DF-R", "O-S-D-L", "O-S-D-R" };
			if (args.Length > 1) {
				string[] lines = File.ReadAllLines(args[0], Encoding.UTF8);
				using (StreamWriter file = new StreamWriter(args[1])) {
					file.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
					file.WriteLine("<Worklist Description=\"\">");
					file.WriteLine("  <RowCollection>");
					foreach (string line in lines) {
						string[] words = line.Split(';');
						
						//Console.WriteLine(words.Length);
						if (words.Length > 20) {
							string[] programname = words[0].Split('.');
							
							if (Array.IndexOf(continuous1, programname[0]) >= 0) {
								//Continuous Frame Countour and Route for glass Programs;
								file.WriteLine("    <ProgramWorklistItem File=\"" + programname[0] + ".bsolid" + "\" Quantity=\"" + words[3] + "\" Counter=\"0\" ExecutionTime=\"--:--:--\" IsExecutionTimeDirty=\"true\" HashCode=\"\" Description=\"" + words[8] + "\" OriginId=\"" + OriginbSolid(words[2]) + "\" Id=\"" + Guid.NewGuid() + "\" Label=\"" + words[8] + "\">");
								file.WriteLine("      <Parameters>");
								file.WriteLine("        <Parameter Name=\"R1_\" Value=\"" + words[15] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R2\" Value=\"" + words[16] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R3\" Value=\"" + words[17] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R4\" Value=\"" + words[18] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R5\" Value=\"" + words[19] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R8\" Value=\"" + words[20] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R9\" Value=\"" + words[21] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R18\" Value=\"" + words[22] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPX\" Value=\"" + words[5] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPY\" Value=\"" + words[6] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPZ\" Value=\"" + words[7] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("      </Parameters>");
								file.WriteLine("    </ProgramWorklistItem>");
							}
							if (Array.IndexOf(continuous2, programname[0]) >= 0) {
								//Continuous Path Door and DrawerFront;
								file.WriteLine("    <ProgramWorklistItem File=\"" + programname[0] + ".bsolid" + "\" Quantity=\"" + words[3] + "\" Counter=\"0\" ExecutionTime=\"--:--:--\" IsExecutionTimeDirty=\"true\" HashCode=\"\" Description=\"" + words[8] + "\" OriginId=\"" + OriginbSolid(words[2]) + "\" Id=\"" + Guid.NewGuid() + "\" Label=\"" + words[8] + "\">");
								file.WriteLine("      <Parameters>");
								file.WriteLine("        <Parameter Name=\"R0\" Value=\"" + words[15] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R1_\" Value=\"" + words[16] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R2\" Value=\"" + words[17] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R3\" Value=\"" + words[18] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R4\" Value=\"" + words[19] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R5\" Value=\"" + words[20] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R7\" Value=\"" + words[21] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R8\" Value=\"" + words[22] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPX\" Value=\"" + words[5] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPY\" Value=\"" + words[6] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPZ\" Value=\"" + words[7] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("      </Parameters>");
								file.WriteLine("    </ProgramWorklistItem>");
							}
							if (Array.IndexOf(continuous3, programname[0]) >= 0) {
								//Continuous Path Mitre;
								file.WriteLine("    <ProgramWorklistItem File=\"" + programname[0] + ".bsolid" + "\" Quantity=\"" + words[3] + "\" Counter=\"0\" ExecutionTime=\"--:--:--\" IsExecutionTimeDirty=\"true\" HashCode=\"\" Description=\"" + words[8] + "\" OriginId=\"" + OriginbSolid(words[2]) + "\" Id=\"" + Guid.NewGuid() + "\" Label=\"" + words[8] + "\">");
								file.WriteLine("      <Parameters>");
								file.WriteLine("        <Parameter Name=\"R0\" Value=\"" + words[15] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R1_\" Value=\"" + words[16] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R2\" Value=\"" + words[17] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R3\" Value=\"" + words[18] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R7\" Value=\"" + words[19] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R8\" Value=\"" + words[20] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPX\" Value=\"" + words[5] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPY\" Value=\"" + words[6] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPZ\" Value=\"" + words[7] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("      </Parameters>");
								file.WriteLine("    </ProgramWorklistItem>");
							}
							if (Array.IndexOf(continuous4, programname[0]) >= 0) {
								//Continuous Path Slab Programs;
								file.WriteLine("    <ProgramWorklistItem File=\"" + programname[0] + ".bsolid" + "\" Quantity=\"" + words[3] + "\" Counter=\"0\" ExecutionTime=\"--:--:--\" IsExecutionTimeDirty=\"true\" HashCode=\"\" Description=\"" + words[8] + "\" OriginId=\"" + OriginbSolid(words[2]) + "\" Id=\"" + Guid.NewGuid() + "\" Label=\"" + words[8] + "\">");
								file.WriteLine("      <Parameters>");
								file.WriteLine("        <Parameter Name=\"R0\" Value=\"" + words[15] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R1_\" Value=\"" + words[16] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R2\" Value=\"" + words[17] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R3\" Value=\"" + words[18] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R7\" Value=\"" + words[19] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R8\" Value=\"" + words[20] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPX\" Value=\"" + words[5] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPY\" Value=\"" + words[6] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPZ\" Value=\"" + words[7] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("      </Parameters>");
								file.WriteLine("    </ProgramWorklistItem>");
							}
							if (Array.IndexOf(discontinuous1, programname[0]) >= 0) {
								//Discontinuous Door and DrawerFront;
								file.WriteLine("    <ProgramWorklistItem File=\"" + programname[0] + ".bsolid" + "\" Quantity=\"" + words[3] + "\" Counter=\"0\" ExecutionTime=\"--:--:--\" IsExecutionTimeDirty=\"true\" HashCode=\"\" Description=\"" + words[8] + "\" OriginId=\"" + OriginbSolid(words[2]) + "\" Id=\"" + Guid.NewGuid() + "\" Label=\"" + words[8] + "\">");
								file.WriteLine("      <Parameters>");
								file.WriteLine("        <Parameter Name=\"R0\" Value=\"" + words[15] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R1_\" Value=\"" + words[16] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R2\" Value=\"" + words[17] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R3\" Value=\"" + words[18] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R4\" Value=\"" + words[19] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R5\" Value=\"" + words[20] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R8\" Value=\"" + words[21] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R6\" Value=\"" + words[22] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPX\" Value=\"" + words[5] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPY\" Value=\"" + words[6] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPZ\" Value=\"" + words[7] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("      </Parameters>");
								file.WriteLine("    </ProgramWorklistItem>");
							}
							if (Array.IndexOf(discontinuous2, programname[0]) >= 0) {
								//Discontinuous Mitre;
								file.WriteLine("    <ProgramWorklistItem File=\"" + programname[0] + ".bsolid" + "\" Quantity=\"" + words[3] + "\" Counter=\"0\" ExecutionTime=\"--:--:--\" IsExecutionTimeDirty=\"true\" HashCode=\"\" Description=\"" + words[8] + "\" OriginId=\"" + OriginbSolid(words[2]) + "\" Id=\"" + Guid.NewGuid() + "\" Label=\"" + words[8] + "\">");
								file.WriteLine("      <Parameters>");
								file.WriteLine("        <Parameter Name=\"R0\" Value=\"" + words[15] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R1_\" Value=\"" + words[16] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R2\" Value=\"" + words[17] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R3\" Value=\"" + words[18] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R8\" Value=\"" + words[19] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R6\" Value=\"" + words[20] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPX\" Value=\"" + words[5] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPY\" Value=\"" + words[6] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPZ\" Value=\"" + words[7] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("      </Parameters>");
								file.WriteLine("    </ProgramWorklistItem>");
							}
							if (Array.IndexOf(discontinuous3, programname[0]) >= 0) {
								//Discontinuous Slab;
								file.WriteLine("    <ProgramWorklistItem File=\"" + programname[0] + ".bsolid" + "\" Quantity=\"" + words[3] + "\" Counter=\"0\" ExecutionTime=\"--:--:--\" IsExecutionTimeDirty=\"true\" HashCode=\"\" Description=\"" + words[8] + "\" OriginId=\"" + OriginbSolid(words[2]) + "\" Id=\"" + Guid.NewGuid() + "\" Label=\"" + words[8] + "\">");
								file.WriteLine("      <Parameters>");
								file.WriteLine("        <Parameter Name=\"R0\" Value=\"" + words[15] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R1_\" Value=\"" + words[16] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R2\" Value=\"" + words[17] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R3\" Value=\"" + words[18] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R8\" Value=\"" + words[19] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"R6\" Value=\"" + words[20] + "\" Scope=\"Viewer\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPX\" Value=\"" + words[5] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPY\" Value=\"" + words[6] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("        <Parameter Name=\"LPZ\" Value=\"" + words[7] + "\" Scope=\"P1001\" Type=\"System.String\" />");
								file.WriteLine("      </Parameters>");
								file.WriteLine("    </ProgramWorklistItem>");
							}
							
							
						}
					}
					file.WriteLine("  </RowCollection>");
					file.WriteLine("</Worklist>");
				}
			}
				
			//Console.ReadKey();
		}
	}
}
