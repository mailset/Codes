using System.Diagnostics;
using OTAKUCore;

namespace OTAKUTest {
    internal class Program {
        static void Main(string[] args) {
            /*
            string result = string.Empty;
            string argument = @"C:\Windows";
            Process process = new Process();
            process.StartInfo.FileName = @"C:\Windows\explorer.exe";
            process.StartInfo.Arguments = argument;
            process.StartInfo.UseShellExecute = true;
            process.Start();
            process.WaitForExit();
            process.Close();
            */

            int[] window = { 600, 400 };

            OTAKUCore.MinecraftManager.Vars vars = new OTAKUCore.MinecraftManager.Vars("op", "OTAKU", "114514", "Windows 11.0", "C:\\Program Files\\Microsoft\\jdk-17.0.5.8-hotspot\\bin\\javaw.exe", "1.17", 4096, "F:\\Game\\Minecraft", "114514191",
                "Windows 11", "6434d35d-5f5f-3fe1-b19a-e522d4e8e86c", "offline", "offline", window);
            OTAKUCore.MinecraftManager.StartMinecraft startMinecraft = new OTAKUCore.MinecraftManager.StartMinecraft();
            startMinecraft.LaunchGame(vars);
        }
    }
}