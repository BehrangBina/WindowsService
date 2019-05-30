using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Timers;

namespace SymbioteProcessService
{
    public partial class SymboyteProcess : ServiceBase
    {
        Process process = new Process();
        Timer timer = new Timer();
        public SymboyteProcess()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //WriteToFile("Service is started at " + DateTime.Now);
            //timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            //timer.Interval = 5000; //number in milisecinds  
            //timer.Enabled = true;
          
            process.StartInfo.FileName = @"D:\Work\nodejs\node.exe";
            process.StartInfo.Arguments = @"D:\Work\nodejs\21.js";
            process.Start();
            //WriteToFile($"Service Started with ID: ${process.Id} Name: {process.ProcessName} Exited?: {process.HasExited}");

        }
        //private void OnElapsedTime(object source, ElapsedEventArgs e)
        //{
        //    WriteToFile("Service is recall at " + DateTime.Now+"\t\t"+ $"Service Started with ID: ${process.Id} Name: {process.ProcessName} Exited?: {process.HasExited}");
        //}
        //private void WriteToFile(string log)
        //{
        //    string path = "";
        //    string filepath = "";
        //    try
        //    {
        //        path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
        //        if (!Directory.Exists(path))
        //        {
        //            Directory.CreateDirectory(path);
        //        }
        //        filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
        //        if (!File.Exists(filepath))
        //        {
        //            // Create a file to write to.   
        //            using (StreamWriter sw = File.CreateText(filepath))
        //            {
        //                sw.WriteLine(log);
        //            }
        //        }
        //        else
        //        {
        //            using (StreamWriter sw = File.AppendText(filepath))
        //            {
        //                sw.WriteLine(log);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.StackTrace);
        //        using (StreamWriter sw = File.AppendText(filepath))
        //        {
        //            sw.WriteLine(e.StackTrace + "\r\n" + log);

        //        }
        //    }
        //}

        protected override void OnStop()
        {
            var processes = Process.GetProcesses();
            var nodeInstances = processes.Where(p => p.ProcessName.ToLower().Contains("node")).ToArray();
            foreach (var nodeInstance in nodeInstances)
            {
                nodeInstance.Kill();
            }
        //    var path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
        //    WriteToFile("Service is stopping " + DateTime.Now + "\t\t" + $"Service Started with ID: ${process.Id} Name: {process.ProcessName} Exited?: {process.HasExited}");
        //    var log = "..... Service has been stopped ....";

        //    if (!Directory.Exists(path))
        //    {
        //        Directory.CreateDirectory(path);
        //    }
        //    var filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
        //    if (!File.Exists(filepath))
        //    {
        //        // Create a file to write to.   
        //        using (StreamWriter sw = File.CreateText(filepath))
        //        {
        //            sw.WriteLine(log);
        //        }
        //    }
        //    else
        //    {
        //        using (StreamWriter sw = File.AppendText(filepath))
        //        {
        //            sw.WriteLine(log);
        //        }
        //    }
        }
    }
}
