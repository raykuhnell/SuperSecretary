using SuperSecretary.Handlers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SuperSecretary
{
    public class Engine
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public EngineOptions Options { get; set; }
        public List<IHandler> Handlers;

        public delegate void ProgressUpdateHandler(int percentProgress, object userState);
        public event ProgressUpdateHandler OnProgressUpdate;

        public Engine(EngineOptions options)
        {
            this.Source = options.Source;
            this.Destination = String.IsNullOrEmpty(options.Destination) ? options.Source : options.Destination;
            this.Options = options;

            Handlers = new List<IHandler>();

            foreach (string prop in options.Properties)
            {
                var hm = HandlerManager.Instance;
                var handler = hm.GetByName(prop);
                if (handler != null)
                {
                    Handlers.Add(handler);
                }
            } 
        }

        public static ScanResult Scan(string source, bool recurseSubdirectories)
        {
            ScanResult sr = new ScanResult();
            sr.Success = true;

            try
            {
                string[] files = Directory.GetFiles(source, "*", recurseSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                sr.Files = files;
                List<string> extensions = new List<string>();
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file).ToLower();
                    if (!extensions.Contains(extension))
                    {
                        extensions.Add(extension);
                    }
                }
                sr.Extensions = extensions.OrderBy(x => x).ToArray();
            }
            catch (Exception ex)
            {
                sr.Success = false;
            }
            
            return sr;
        }

        public void Process()
        {
            HandlerOptions ho = new HandlerOptions() { DateFormatString = Options.DateFormatString };

            int count = 0;
            var files = Directory.GetFiles(Source, "*", Options.RecurseSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

            foreach (var file in files)
            {
                count++;
                string status = String.Empty;
                string extension = Path.GetExtension(file).ToLower();
                if (Options.FileExtensions.Length < 1 || Options.FileExtensions.Contains(extension))
                {
                    string value = String.Empty;
                    foreach (var handler in Handlers)
                    {
                        var result = handler.Do(file, ho);
                        if (String.IsNullOrEmpty(result.Value) && !Options.SkipFolder)
                        {
                            value = Path.Combine(value, Options.MissingFolderName);
                        }
                        else if (!String.IsNullOrEmpty(result.Value))
                        {
                            value = Path.Combine(value, result.Value);
                        }
                        if (result.Exception != null)
                        {
                            status += String.Format("An error occurred retrieving {0} : {1}", handler.Name, result.Exception.Message);
                        }
                    }
                    status += String.Format("Organizing file {0} of {1}.", count, files.Length);

                    try
                    {
                        string destinationDirectory = Path.Combine(Destination, value);
                        if (!Directory.Exists(destinationDirectory))
                        {
                            Directory.CreateDirectory(destinationDirectory);
                        }

                        string destinationFile = Path.Combine(destinationDirectory, Path.GetFileName(file));
                        if (!File.Exists(destinationFile) || Options.OverwriteExistingFiles)
                        {
                            if (Options.Copy)
                            {
                                File.Copy(file, destinationFile);
                            }
                            else
                            {
                                File.Move(file, destinationFile);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        status += String.Format("An error occurred while trying to sort the file: {0}.  {1}", file, ex.Message);
                    }
                }
                else
                {
                    status = String.Format("Skipped file {0}.  File is not on the list of selected extensions.", file);
                }

                if (OnProgressUpdate != null)
                {
                    OnProgressUpdate((int)Math.Round((double)(100 * count) / files.Length), status);
                }
            }
        }
    }
}
