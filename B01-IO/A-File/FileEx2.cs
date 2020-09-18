using System;
using System.IO;

namespace A_File
{
    public class FileEx2
    {
        public static void Main(string[] args) 
        {
            string directory;
            Console.WriteLine("조사할 디렉토리 이름을 입력하세요");
            directory = Console.ReadLine();
            Console.WriteLine("몇 일 이전에 사용하지 않은 파일을 보여드릴까요?");

            int diff = Int32.Parse(Console.ReadLine());
            DateTime dt = DateTime.Today;
            dt = dt.Subtract(new TimeSpan(diff, 0, 0, 0));
            
            DirectoryInfo di = new DirectoryInfo(directory);
            FileSystemInfo[] results = di.GetFileSystemInfos();
            foreach (FileSystemInfo fi in results)
            {
                DateTime tmp = new DateTime(fi.LastAccessTime.Year,
                fi.LastAccessTime.Month, fi.LastAccessTime.Day);

                if (tmp <= dt)
                {
                    Console.WriteLine("{0} 파일 혹은 디렉토리는 {1} 에 마지막에 접근했습니다.", fi.Name, fi.LastAccessTime);
                }
            }
        }
        

    }
}