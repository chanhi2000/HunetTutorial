using System;
using System.IO;

namespace A_File
{
    public class FileEx1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("파일 이름이나 디렉토리 이름을 입력하세요.");
            string filename = Console.ReadLine();

            FileInfo fi = new FileInfo(filename);
            Console.WriteLine(filename + (fi.Exists ? "파일 있음" : "파일없음"));

            string directoryname = filename;
            DirectoryInfo di = new DirectoryInfo(directoryname);
            Console.WriteLine(directoryname + (di.Exists ? "디렉토리 있음" : "디렉토리없음"));

            FileInfo[] ff = di.GetFiles();  // 디렉토리의 파일목록
            Console.WriteLine("\n\n 파일의 목록");
            foreach (FileInfo abc in ff) 
            {
                Console.WriteLine("file = "+abc.Name);
            }

            // 현재 디렉토리의 하위 디렉토리를 반환
            DirectoryInfo[] dd = di.GetDirectories();
            foreach (DirectoryInfo yyy in dd)
            {
                Console.WriteLine("Directories="+yyy);
            }
        }
    }
}
