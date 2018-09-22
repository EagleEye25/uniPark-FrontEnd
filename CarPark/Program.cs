using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;


namespace CarPark
{
    class Program
    {
        // Code from Stack Overflow
 //       [DllImport("user32.dll")]
 //       static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

 //       [DllImport("Kernel32")]
 //       private static extern IntPtr GetConsoleWindow();

   //     const int SW_HIDE = 0;
  //      const int SW_SHOW = 5; 
          static void Main(string[] args)
          {
         //   IntPtr hwnd;
         //   hwnd = GetConsoleWindow();
         //   ShowWindow(hwnd, SW_HIDE); 
           // string path = "C:/Users/Wihan/Desktop/Wihan/NMMU/Project 3de Year/uniPark-FrontEnd/CarParkFront/bin/Debug";
              var proc = new Process
              {
                  StartInfo = new ProcessStartInfo
                  {
                      FileName = "alpr.exe",
                      Arguments = "-c za myImage.jpg",
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

            // File format Plate, Accuracy, count
            //  File.Delete(@"C: \Users\Wihan\Desktop\Wihan\NMMU\Project 3de Year\uniPark-FrontEnd\CarParkFront\bin\Debug\Plate.txt");

            System.IO.File.WriteAllText(@"C: \Users\Wihan\Desktop\Wihan\NMMU\Project 3de Year\uniPark-FrontEnd\CarParkFront\bin\Debug\Plate.txt", line + ',' + accuracy.Split(' ')[1]);

            Console.WriteLine(line);
            Console.WriteLine(accuracy.Split(' ')[1]);

            Console.ReadLine();
            
        }

    }
    }
