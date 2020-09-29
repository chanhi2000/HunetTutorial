using System;
using System.Collections.Generic;
using System.Linq;

namespace C_QueryOp
{
    public class LetTest
    {
        public static void Main()
        {
            string[] words = 
            {
                "시작과 끝은 노력의 차이다.",
                "삶과 죽음은 시간의 차이다.",
                "행복과 불행은 생각의 차이다."
            };
            
            var bquery = from res in words
                let word = res.Substring(0,2)
                select word;

            foreach(var v in bquery)
            {
                System.Console.WriteLine("{0}", v);
            }
        }
        
    }
}