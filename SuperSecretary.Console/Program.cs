using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSecretary;

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
                }

                Engine engine = new Engine(source, destination, properties, options);

                try
                {
                    engine.Process();
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

        static void ShowHelp()
        {
            System.Console.WriteLine("SuperSecretary Usage: SuperSecretary source destination [OPTIONS]");
            System.Console.WriteLine("Sorts the files in the source directory to the destination according to the options.");
            System.Console.WriteLine();
            System.Console.WriteLine("Options: (settings are used for defaults)");
            System.Console.WriteLine("  -p, --properties names              A comma-separated list of properties to sort on.  See documentation for more.");
            System.Console.WriteLine("  -r, --recurse                       Recurse to all subdirectories.");
            System.Console.WriteLine("  -m, --move                          Move files to destination.  Omitting this option copies the files.");
            System.Console.WriteLine("  -e, --extensions file-exts          A comma-separated list of file extensions to sort.  (ex. .jpg,.gif,.png)");
            System.Console.WriteLine("  -h, --help                          Show the help message.");
        }
    }
}
