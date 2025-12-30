/*
 * Created by SharpDevelop.
 * User: CA01114
 * Date: 2019-07-20
 * Time: 09:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;

namespace BNEST
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			SqlConnection myConnection = new SqlConnection("user id=ExternalUser;" +
			                                               "password=externaluser;server=LOCALHOST\\BNEST;" +
			                                               "Trusted_Connection=yes;" +
			                                               "database=bNestRover; " +
			                                               "connection timeout=10");
			
			try
			{
				myConnection.Open();
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			
			/*
			try
			{
				SqlDataReader myReader = null;
				SqlCommand    myCommand = new SqlCommand("select * from SqlCommand",
				                                         myConnection);
				myReader = myCommand.ExecuteReader();
				while(myReader.Read())
				{
					Console.WriteLine(myReader["CmdCode"].ToString());
					Console.WriteLine(myReader["Parameters"].ToString());
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			 */
			try
			{
				SqlCommand myCommand= new SqlCommand("INSERT INTO SqlCommand (CmdCode, Parameters) " +
				                                     "Values (1, '-t csv -f C:\\Users\\ca01114\\Documents\\bSolid\\AWFS\\project_bnest\\AWFS_SOFA.csv')", myConnection);
				myCommand.ExecuteNonQuery();
								 myCommand= new SqlCommand("INSERT INTO SqlCommand (CmdCode, Parameters) " +
				                                     "Values (1, '-t csv -f C:\\Users\\ca01114\\Documents\\bSolid\\AWFS\\project_bnest\\AWFS_SOFA.csv')", myConnection);
				myCommand.ExecuteNonQuery();
								 myCommand= new SqlCommand("INSERT INTO SqlCommand (CmdCode, Parameters) " +
				                                     "Values (1, '-t csv -f C:\\Users\\ca01114\\Documents\\bSolid\\AWFS\\project_bnest\\AWFS_SOFA.csv')", myConnection);
				myCommand.ExecuteNonQuery();
								 myCommand= new SqlCommand("INSERT INTO SqlCommand (CmdCode, Parameters) " +
				                                     "Values (1, '-t csv -f C:\\Users\\ca01114\\Documents\\bSolid\\AWFS\\project_bnest\\AWFS_SOFA.csv')", myConnection);
				myCommand.ExecuteNonQuery();
								 myCommand= new SqlCommand("INSERT INTO SqlCommand (CmdCode, Parameters) " +
				                                     "Values (1, '-t csv -f C:\\Users\\ca01114\\Documents\\bSolid\\AWFS\\project_bnest\\AWFS_SOFA.csv')", myConnection);
				myCommand.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			
			try
			{
				myConnection.Close();
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}