using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsFinalProject
{
    
    public class clsCurrentlyRunning
    {
       public bool running;

        public string opened(string name)
        {
            running = true;
            return name;
        }

        public void closed()
        {
            running = false;
            
        }
    }
}
