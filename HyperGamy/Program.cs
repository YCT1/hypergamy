using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Numerics;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using Accord.Statistics;

namespace HyperGamy
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Console.WriteLine("test");
            Form1 form1 = new Form1();
            for (int x = 0; x < 1000; x++)
            {
                string command;
                Console.WriteLine("\nPlease Write A Command");
                Console.WriteLine("");
                command = Console.ReadLine();
                if(command == "help")
                {
                    Console.Write("\nLOL\n");
                   
                }
                if (command == "clear")
                {
                    Console.Clear();

                }
                if(command == "setup -m")
                {
                    form1.mannumber = Convert.ToInt32( Console.Read());
                }
                if (command == "setup -m")
                {
                    form1.mannumber = Convert.ToInt32(Console.Read());
                }
                if(command == "setup -ul")
                {
                    form1.upperGroupLimit = Convert.ToInt32(Console.Read());
                }
                if (command == "setup -ll")
                {
                    form1.lowerGroupLimit = Convert.ToInt32(Console.Read());
                }
                if (command == "setup -ull")
                {
                    int both = 0;
                    both = Convert.ToInt32(Console.Read());
                    form1.upperGroupLimit = both;
                    form1.lowerGroupLimit = both;
                }
                if(command == "run")
                {
                    form1.Hesaplama();
                    form1.Groupla();
                    form1.toplaf();
                }
                if(command == "show -smv")
                {
                    int a;
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(form1.myMen[a].LMS.ToString());
                }

            }
            
            
            
        }

    }
}
