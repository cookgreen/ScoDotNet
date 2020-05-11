using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCO.Managed;

namespace SCO.Test
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new frmMain());
        }
    }
}
