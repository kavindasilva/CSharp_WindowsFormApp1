using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ext1Control //control class
    {
        public ext1Control()
        {
            Console.Write("ext1 cons1 control");
        }

        //cmd run code
        public void runEvent(string sender, string cmd)
        //public void runEvent(Object sender, string cmd)
        {
            //Console.WriteLine(sender.ToString());

            if (sender.ToString() == "py")
            {
                //MessageBox.Show("python");
                new ext1Model().runPython(cmd);
                

            }
            else if (sender.ToString() == "Cmd")
            {
                //MessageBox.Show("cmd shell");
                new ext1Model().runCmd(cmd);
            }
            else if (sender.ToString() == "Java")
            {
                //MessageBox.Show("java");
            }


        }


    }



    class ext1Model //entity class
    {
        public void runPython(string command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C python "+ command;
            process.StartInfo = startInfo;

            process.Start();
        }

        public void runCmd(string command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C  " + command;
            process.StartInfo = startInfo;

            process.Start();
        }

        public void runJava(string command)
        {
        }

        public void runAny(string[] args)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = "/C python";
            startInfo.Arguments = args[0];
            process.StartInfo = startInfo;

            process.Start();
        }
    }
}
