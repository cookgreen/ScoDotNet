using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCO.Managed;

namespace SCO.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            SCOLoader loader = new SCOLoader();
            SCOFile sco = loader.Read(@"");
            Console.WriteLine(sco.AIMeshes.Count);
            Console.Read();
        }
    }
}
