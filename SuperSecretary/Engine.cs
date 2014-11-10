using SuperSecretary.Events;
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

        public delegate void ProgressUpdateHandler(object sender, ProgressEventArgs e);
        public event ProgressUpdateHandler OnProgressUpdate;

        public Engine(string source, string destination, string[] properties, EngineOptions options)
        {
            this.Source = source;
            this.Destination = destination;
            this.Options = options;

            Handlers = new List<IHandler>();

            foreach (string prop in properties)
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
            HandlerOptions ho = new HandlerOptions();
            ho.DateFormatString = @"\" + Options.YearFormatString;
            if (Options.SortByMonth)
            {
                ho.DateFormatString += @"\" + Options.MonthFormatString;
            }

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
                        value += @"\" + result.Value;

                        if (result.Exception != null)
                        {
                            status += String.Format("An error occurred retrieving {0} : {1}", handler.Name, result.Exception.Message);
                        }
                    }

                    if (!String.IsNullOrEmpty(value))
                    {
                        if (String.IsNullOrEmpty(Destination))
                        {
                            Destination = Source;
                        }

                        try
                        {
                            if (!Directory.Exists(Destination + value))
                            {
                                Directory.CreateDirectory(Destination + value);
                            }

                            if (Options.Copy)
                            {
                                File.Copy(file, Destination + value + @"\" + Path.GetFileName(file));
                            }
                            else
                            {
                                File.Move(file, Destination + value + @"\" + Path.GetFileName(file));
                            }
                        }
                        catch (Exception ex)
                        {
                            status += String.Format("An error occurred while trying to sort the file: {0}.  {1}", file, ex.Message);
                        }
                        
                        status += String.Format("Organizing file {0} of {1}.", count, files.Length);
                    }
                    else
                    {
                        status = String.Format("Skipped file {0}.  File could not be sorted.", file);
                    }
                }
                else
                {
                    status = String.Format("Skipped file {0}.  File is not on the list of selected extensions.", file);
                }

                ProgressEventArgs args = new ProgressEventArgs(status, count, files.Length);
                if (OnProgressUpdate != null)
                {
                    OnProgressUpdate(this, args);
                }
            }
        }
    }
}
