using System;
using System.IO;

namespace SuperSecretary.Handlers
{
    public class DateCreatedHandler : IHandler
    {
        public string Name
        {
            get
            {
                return "Date Created";
            }
        }

        public HandlerResult Do(string fileName, HandlerOptions options)
        {
            var result = new HandlerResult();

            try
            {
                result.Value = File.GetCreationTime(fileName).ToString(options.DateFormatString);
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }
    }
}
