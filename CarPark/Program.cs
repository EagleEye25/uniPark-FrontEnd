using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace CarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "alpr.exe",
                    Arguments = "-c za za_dlf362ec.jpg",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();

            int i = 0;
            string line = "";
            string accuracy = "";

            while (i++ < 2)
            {
                line = proc.StandardOutput.ReadLine().Trim().Trim('-').Trim();
                if (i > 1)
                {
                    line = line.Replace("  ", "?");
                    string[] split = line.Split('\t');
                    line = split[0].Trim();
                    accuracy = split[1].Trim();
                }
            }
            Console.WriteLine(line);
            Console.WriteLine(accuracy.Split(' ')[1]);
            Console.ReadLine();
        }
    }
}
