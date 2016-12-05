using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(KingLion.WebUtils.NPinyin.Pinyin.GetPinyin("中华人民共和国","-"));
            Console.Read();
        }
    }
}
