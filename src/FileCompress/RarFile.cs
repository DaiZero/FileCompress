using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompress
{
    public class RarFile : IRarFile
    {
        public static string ExistsWinRar()
        {
            string result = string.Empty;

            string key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe";
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(key);
            if (registryKey != null)
            {
                result = registryKey.GetValue("").ToString();
            }
            registryKey.Close();

            return result;
        }

        public bool Compress(string fileOrDirPath, string rarFilePath)
        {
            throw new NotImplementedException();
        }

        public bool DeCompress(string rarFilePath, string destDirPath, string password = null)
        {
            string winrarPath = ExistsWinRar();
            if (string.IsNullOrEmpty(winrarPath))
            {
                throw new Exception("未安装WinRAR程序。");
            }
            string shellArguments = null;
            if (string.IsNullOrEmpty(password))
            {
                shellArguments = $"x -o+ \"{rarFilePath}\" \"{destDirPath}\\\"";
            }
            else
            {
                shellArguments = $"x -p\"{password}\" -o+ \"{rarFilePath}\" \"{destDirPath}\\\"";
            }
            using (var process = new Process())
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = winrarPath,
                    Arguments = shellArguments,
                    WindowStyle = ProcessWindowStyle.Hidden //隐藏 WinRAR 窗口
                };

                process.StartInfo = processStartInfo;
                process.Start();
                process.WaitForExit();
                process.Close();

            }
            return true;
        }
    }
}
