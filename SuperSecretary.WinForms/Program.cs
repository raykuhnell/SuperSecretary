using System;
using System.Linq;
using System.Windows.Forms;

namespace SuperSecretary.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
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
                    string[] properties = new string[] {};
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
                        Console.WriteLine("An error occurred trying to access files.  " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An unknown error occurred.  " + ex.Message);
                    }

                    Console.WriteLine("Process completed!");
                }  
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
        }
        
        static void ShowHelp()
        {
            Console.WriteLine("SuperSecretary Usage: SuperSecretary source destination [OPTIONS]");
            Console.WriteLine("Sorts the files in the source directory to the destination according to the options.");
            Console.WriteLine();
            Console.WriteLine("Options: (settings are used for defaults)");
            Console.WriteLine("  -p, --properties names              A comma-separated list of properties to sort on.  See documentation for more.");
            Console.WriteLine("  -r, --recurse                       Recurse to all subdirectories.");
            Console.WriteLine("  -m, --move                          Move files to destination.  Omitting this option copies the files.");
            Console.WriteLine("  -e, --extensions file-exts          A comma-separated list of file extensions to sort.  (ex. .jpg,.gif,.png)");
            Console.WriteLine("  -h, --help                          Show the help message.");
        }
    }
}
