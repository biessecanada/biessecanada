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
		static void Main(string[] args)
		{
			if (args.Length == 2) {
				string[] lines = File.ReadAllLines(args[0] + ".lst", Encoding.UTF8);
				using (StreamWriter file = new StreamWriter(args[1] + ".bwkl")) {
					file.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
					file.WriteLine("<Worklist Description=\"\">");
					file.WriteLine("  <RowCollection>");
					foreach (string line in lines) {
						string[] words = line.Split(',');
						//Console.WriteLine(words.Length);
						if (words.Length == 6) {				
							file.WriteLine("    <ProgramWorklistItem File=\"C:/WNC/home/d_xnc/p_p/prog/" + words[1] + "\" Quantity=\"" + words[2] + "\" Counter=\"" + words[3] + "\" ExecutionTime=\"--:--:--\" IsExecutionTimeDirty=\"false\" HashCode=\"\" Description=\"\" OriginId=\"-1\" Id=\"" + Guid.NewGuid() + "\" Label=\"" + words[0] + "\">");
							file.WriteLine("    </ProgramWorklistItem>");							
						}
					}
					file.WriteLine("  </RowCollection>");
					file.WriteLine("</Worklist>");
				}
			} else {
				Console.WriteLine("you need to enter source list and destination list");
			}
				
			//Console.ReadKey();
		}
	}
}
