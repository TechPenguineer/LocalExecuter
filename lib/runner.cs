using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using System.Text.Json;

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
                DirectoryInfo di = Directory.CreateDirectory(dir);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
            else { }
        }
        public static void CreateRunnerFileContents(string RunnerName, string RunnerStartScript)
        {
            string RunnerDIR = $"{dir}\\{RunnerName}.json";

            var runnerData = new RunnerData
            {
                RunnerName = RunnerName,
                RunnerSS = RunnerStartScript
            };

            string JSONData = JsonSerializer.Serialize(runnerData);
            string JSONDataFormated = $"{JSONData}\n";

            File.AppendAllText(RunnerDIR, JSONDataFormated);

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
    public class RunnerData
    {
        public string RunnerName { get; set; }
        public string RunnerSS { get; set; }
    }
}
