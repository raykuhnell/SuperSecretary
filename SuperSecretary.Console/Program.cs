using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSecretary;
using SuperSecretary.Events;

namespace SuperSecretary.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Contains("-h") || args.Contains("--help"))
            {
                ShowHelp();
                return;
            }

            if (args.Length > 1)
            {
                string source = args[0];
                string destination = args[1];
                string[] properties = new string[] { };
                EngineOptions options = new EngineOptions();

                string logFilePath = String.Empty;

                for (int i = 2; i < args.Length; i++)
                {
                    if (args[i] == "-p" || args[i] == "--props")
                    {
                        i++;
                        if (i < args.Length)
                        {
                            properties = args[i].Split(',');
                        }
                    }
                    else if (args[i] == "-r" || args[i] == "--recurse")
                    {
                        options.RecurseSubdirectories = true;
                    }
                    else if (args[i] == "-m" || args[i] == "--move")
                    {
                        options.Copy = false;
                    }
                    if (args[i] == "-e" || args[i] == "--exts")
                    {
                        i++;
                        if (i < args.Length)
                        {
                            options.FileExtensions = args[i].Split(',');
                        }
                    }
                    if (args[i] == "-u" || args[i] == "--unsorted")
                    {
                        i++;
                        if (i < args.Length)
                        {
                            options.MissingFolderName = args[i];
                        }
                    }
                    if (args[i] == "-d" || args[i] == "--date")
                    {
                        i++;
                        if (i < args.Length)
                        {
                            options.DateFormatString = args[i];
                        }
                    }
                    if (args[i] == "-l" || args[i] == "--log")
                    {
                        i++;
                        if (i < args.Length)
                        {
                            logFilePath = args[i];
                        }
                    }
                }

                Engine engine = new Engine(source, destination, properties, options);
                engine.OnProgressUpdate += Engine_ProgressUpdate;

                try
                {
                    engine.Process();

                    if (!String.IsNullOrEmpty(logFilePath))
                    {
                        Log.Save(logFilePath);
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    System.Console.WriteLine("An error occurred trying to access files.  " + ex.Message);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("An unknown error occurred.  " + ex.Message);
                }

                System.Console.WriteLine("Process completed!");
            }
        }

        private static void Engine_ProgressUpdate(object sender, ProgressEventArgs e)
        {
            System.Console.WriteLine(e.Status);
            Log.Write(e.Status);
        }

        static void ShowHelp()
        {
            System.Console.WriteLine("SuperSecretary Usage: SuperSecretary.Console source destination [OPTIONS]");
            System.Console.WriteLine("Sorts the files in the source directory to the destination according to the options.");
            System.Console.WriteLine();
            System.Console.WriteLine("Options:");
            System.Console.WriteLine("  -p, --properties names              A comma-separated list of properties to sort on.  See documentation for more.");
            System.Console.WriteLine("  -r, --recurse                       Recurse to all subdirectories.");
            System.Console.WriteLine("  -m, --move                          Move files to destination.  Omitting this option copies the files.");
            System.Console.WriteLine("  -e, --extensions file-exts          A comma-separated list of file extensions to sort.  (ex. .jpg,.gif,.png)");
            System.Console.WriteLine("  -u, --unsorted folder               The folder to sort to when an attribute value is not found.");
            System.Console.WriteLine("  -d, --date format                   A .NET date format string for generating folder names from date attributes.");
            System.Console.WriteLine("  -l, --log path                      Log the results to a file at the specified path.");
            System.Console.WriteLine("  -h, --help                          Show the help message.");
        }
    }
}
