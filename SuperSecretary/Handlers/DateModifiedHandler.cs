using System;
using System.IO;

namespace SuperSecretary.Handlers
{
    public class DateModifiedHandler : IHandler
    {
        public string Name
        {
            get
            {
                return "Date Modified";
            }
        }

        public HandlerResult Do(string fileName, HandlerOptions options)
        {
            var result = new HandlerResult();

            try
            {
                result.Value = File.GetLastWriteTime(fileName).ToString(options.DateFormatString);
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }
    }
}
