using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BlinkerService
{
    public partial class BlinkerSRV : ServiceBase
    {
        public BlinkerSRV()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            File.WriteAllText("c:/lavoro-tempo/log.txt", "Starting " + DateTime.Now.ToString());
        }

        protected override void OnStop()
        {
            File.WriteAllText("c:/lavoro-tempo/log.txt", "Stopping " + DateTime.Now.ToString());
        }
    }
}
