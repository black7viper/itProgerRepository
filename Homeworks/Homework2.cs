using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger
{
    public class Homework2
    {
        public static void Main()
        {
            homework2();
        }

        public static void homework2()
        {
            Dictionary<string, string?> dic = new Dictionary<string, string?>();
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter file name:");
                string? fn = Console.ReadLine();
                if (fn == null) fn = "";
                Console.Write("Enter file content:");
                string? fc = Console.ReadLine();
                if (fc == null) fc = "";
                dic.Add(fn, fc);
            }

            string[] keys = dic.Keys.ToArray();
            keys = keys.Where(key => key.ToLower().StartsWith("q")).ToArray();
            foreach (string key in keys)
            {
                byte[] sTob = System.Text.Encoding.Default.GetBytes(dic[key]);
                using (FileStream fs = new FileStream("D:\\Projects_C#\\itProgerGit\\" + key, FileMode.Create))
                {
                    fs.Write(sTob);
                }
            }
        }

    }

}
