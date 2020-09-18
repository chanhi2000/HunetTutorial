using System;
using System.IO;

namespace C_Binary
{
    public class Binary
    {
        public static void Binary_Write()
        {
            using (Stream stream = File.OpenWrite("BinaryReaderWriter.bin"))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(stream))
                {
                    for (int i=0; i <= 100; ++i)
                    {
                        binaryWriter.Write(i);
                    }
                }
            }
        }

        public static void Binary_Read()
        {
            using (Stream stream02 = File.OpenRead("BinaryReaderWriter.bin"))
            {
                using (BinaryReader binaryReader = new BinaryReader(stream02))
                {
                    for (long cp = stream02.Length -4; cp >= 0; cp -= 4)
                    {
                        stream02.Position = cp;
                        Console.Write("{0,4}", binaryReader.ReadInt32());
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            Binary_Write();
            Binary_Read();
        }
    }
}
