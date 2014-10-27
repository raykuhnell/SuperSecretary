using System;
using System.IO;

namespace SuperSecretary.Handlers
{
    public class FileExtensionHandler : IHandler
    {
        public string Name
        {
            get
            {
                return "File Extension";
            }
        }

        public HandlerResult Do(string fileName, HandlerOptions options)
        {
            var result = new HandlerResult();

            try
            {
                result.Value = Path.GetExtension(fileName).Substring(1).ToLower();
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }
    }
}
