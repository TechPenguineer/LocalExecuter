using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LocalExecuter.lib
{
    class runner
    {
        public static String appdata_directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static String dir = $"{appdata_directory}\\.LocalExecuter\\storage";

        public static void CreateMainDirectoryForStorage()
        {
            if(!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            else { }
        }
        public static void CreateRunnerFile(string RunnerName)
        {
            CreateMainDirectoryForStorage();
            if (!File.Exists($"{dir}\\{RunnerName}.json"))
            {
                File.Create($"{dir}\\{RunnerName}.json");
            }
            else
            {
                MessageBox.Show("The runner file already exists!", "Local Executer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
