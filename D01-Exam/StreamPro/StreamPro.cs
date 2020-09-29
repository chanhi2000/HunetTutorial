using System;
using System.IO;

namespace StreamPro
{
    public class StreamPro
    {
        public static void Main(string[] args)
        {
            StreamPro instance = new StreamPro();
            instance.output();
            instance.Input();
        }

        public void Input()
        {
            Stream stream = File.OpenRead("TestFile.txt");
            using(StreamReader streamReader = new StreamReader(stream))
            {   
                string line;
                while((line = streamReader.ReadLine()) != null)
				{
					Console.WriteLine(line);
				}                
                streamReader.Close();
            }
            
        }

        public void output()
        {
            Stream stream = File.OpenWrite("TestFile.txt");
            using(StreamWriter streamWriter = new StreamWriter(stream))
            {
                streamWriter.WriteLine("봄 여름 가을 겨울의 사계절 중 난 겨울이 가장 좋습니다.");
                streamWriter.WriteLine("");
                DateTime dt = DateTime.Now;
                streamWriter.WriteLine("현재 시간은 {0} 입니다.", dt);
                streamWriter.Flush();
            }
            stream.Close();
        }
    }
}
