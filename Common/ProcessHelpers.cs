using System.Diagnostics;

namespace Common;

public static class ProcessHelpers
{
    public static void ExecuteScripts(string command, string arguments, string workingDirectory = null)
    {
        // Execute the script
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = command,
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = workingDirectory
            }
        };

        process.Start();
        process.WaitForExit();

        // Log the output
        var output = process.StandardOutput.ReadToEnd();
        var error = process.StandardError.ReadToEnd();
        process.WaitForExit();

        if (!string.IsNullOrEmpty(output))
        {
            Console.WriteLine(output);
        }

        if (!string.IsNullOrEmpty(error))
        {
            Console.WriteLine(error);
        }
        process.Close();
    }
}
