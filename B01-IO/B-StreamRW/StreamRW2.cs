using System;
using System.IO;

namespace  B_StreamRW
{
	public class StreamRW2
	{
		public static void ReadTest()
		{
			try 
			{
				using (StreamReader sr = new StreamReader("test2.txt"))
				{
					String line;
					while((line = sr.ReadLine()) != null)
					{
						Console.WriteLine(line);
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("The file could not be read");
				Console.WriteLine(e.Message);
			}
		}

		public static void Main(string[] args)
		{
			using (StreamWriter sw = new StreamWriter("test2.txt"))
			{
				// `using` 사용시 `Close()` 호출 이 필수가 아님
				sw.Write("This is the ");
				sw.WriteLine("header for the file. ");
				sw.WriteLine("------------------");
				sw.Write("The date is ");
				sw.WriteLine(DateTime.Now);
			}
			ReadTest();
		}
	}
}