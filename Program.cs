using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace EarTrumpetFxSoundFix
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            if (WaitForProcess("FxSound", 10000))
            {
                Thread.Sleep(2000);
                ExecuteShortcuts();
            }
            else
            {
                MessageBox.Show("FxSound not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static bool WaitForProcess(string processName, int timeout)
        {
            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < timeout)
            {
                if (Process.GetProcessesByName(processName).Length > 0)
                {
                    return true;
                }
                Thread.Sleep(100);
            }
            return false;
        }

        static void ExecuteShortcuts()
        {
            string shortcutsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "shortcuts");
            if (Directory.Exists(shortcutsFolder))
            {
                var shortcutFiles = Directory.GetFiles(shortcutsFolder, "*.lnk");
                foreach (var shortcut in shortcutFiles)
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = shortcut,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
            }
            else
            {
                MessageBox.Show("Shortcuts folder not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
