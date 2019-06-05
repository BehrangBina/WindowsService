using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbioteProcessService
{
    public class ProcessTThread
    {
        public static ProcessThreadCollection GetProcessThreads()
        {
            Process CurrentProcess = Process.GetCurrentProcess();
            ProcessThreadCollection threadList = CurrentProcess.Threads;
            return threadList;
        }
        //https://blogs.msdn.microsoft.com/kebab/2014/04/28/executing-powershell-scripts-from-c/
        //https://www.codeproject.com/Articles/35773/Subverting-Vista-UAC-in-Both-and-bit-Archite
        //https://github.com/murrayju/CreateProcessAsUser
        //https://blogs.msdn.microsoft.com/winsdk/2009/07/14/launching-an-interactive-process-from-windows-service-in-windows-vista-and-later/
        //https://chasewright.com/2015/12/26/session0bypass/
    }
}
