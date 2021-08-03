using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LocalExecuter.lib
{
    class utill
    {
        public static void IfDirectoryDoesntExistDo(string path)
        {
            if(!Directory.Exists(path))
            { }
        }
    }
}
