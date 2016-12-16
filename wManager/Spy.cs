using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows; 

namespace wManager
{
    class Spy
    {
        int a; 
        public Spy()
        {
            Process[] processes; 
        }

        public Process[]  getProccesses(){

            Process[] processes = Process.GetProcesses();
            //processes[1];
            return processes;
            }

     //   progr
    }
}
