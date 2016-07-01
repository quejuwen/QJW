using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QJW;

namespace QJW.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = string.Empty;
            //msg = Easp.MD5("111111",16).ToLower();

            msg = "4l35xhbN+4tsut7S1U+BTHbIa1wPReCnzSj/n3ZFtHCyjdEiALglOcRZHUQy1jMmg+LAw0koq0M5vmm+WSu5zE+VU8swALZs";

            msg = "quejuwen";

            msg = Easp.EncryptString(msg, "FANGPAGE");
            //msg = Easp.DecryptString(msg, "FANGPAGE");

            msg = Easp.DecryptString("763CDF64BA62666938F0708D1BA3A1FC", "FANGPAGE");

            Console.WriteLine(msg);
        }
    }
}
