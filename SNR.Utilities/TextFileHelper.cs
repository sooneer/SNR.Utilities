using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNR.Utilities;

public static class TextFileHelper
{
    public static void Write(string message)
    {
        string directoryPath = AppDomain.CurrentDomain.BaseDirectory + "logs\\";
        directoryPath = directoryPath.Replace("\\bin\\Debug\\net6.0", "");
        directoryPath = directoryPath.Replace("\\bin\\Debug\\net7.0", "");
        string filePath = directoryPath + DateTime.Now.ToString("yyyy-MM-dd") + "_error.log";

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        using (var streamWriter = new StreamWriter(filePath, true))
        {
            streamWriter.WriteLine(message);
            streamWriter.Close();
        }
    }

    public static void Write(string filePath, string message)
    {
        using (var streamWriter = new StreamWriter(filePath, true))
        {
            streamWriter.WriteLine(message);
            streamWriter.Close();
        }
    }

    public static void Write(string directoryPath, string fileName, string message)
    {
        using (var streamWriter = new StreamWriter(Path.Combine(directoryPath, fileName), true))
        {
            streamWriter.WriteLine(message);
            streamWriter.Close();
        }
    }
}