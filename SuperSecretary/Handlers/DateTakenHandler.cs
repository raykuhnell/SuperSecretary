using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace SuperSecretary.Handlers
{
    public class DateTakenHandler : IHandler
    {
        enum PropertyIds
        {
            DateTaken = 36867
        }

        public string Name
        {
            get
            {
                return "Date Taken";
            }
        }

        public HandlerResult Do(string fileName, HandlerOptions options)
        {
            var result = new HandlerResult();

            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (Image image = Image.FromStream(fs, false, false))
                    {
                        var propertyItem = image.GetPropertyItem((int)PropertyIds.DateTaken);
                        string date = Encoding.UTF8.GetString(propertyItem.Value, 0, propertyItem.Len - 1);
                        var dateTaken = DateTime.ParseExact(date, "yyyy:MM:dd HH:mm:ss", null);
                        result.Value = dateTaken.ToString(options.DateFormatString);
                    }
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }
    }
}
