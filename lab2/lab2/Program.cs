using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\ND602374\Desktop\10311221BigData homework\lab-2-zi-chuan-chu-li-eftgy2458\Data\Input.txt"))
            //using (StreamReader sr = new StreamReader(@"..\..\..\..\Data\Intput.txt"))
            {
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        if(ch == '\u0021')
                            Console.Write("!\n");
                        else if (ch == '\u002E')
                            Console.Write(".\n");
                        else if (ch == '\u003F')
                            Console.Write("?\n");
                        else
                            Console.Write(ch);
                    }

                }
            
            }
        }
    }
}