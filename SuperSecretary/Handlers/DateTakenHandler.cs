﻿using System;
using System.Drawing;
using System.IO;
using System.Text;
using SuperSecretary.Utilities;

namespace SuperSecretary.Handlers
{
    public class DateTakenHandler : IHandler
    {
        private const int PROPERTY_ID = 0x9003;

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
                string date = ExifUtilities.GetProperty(fileName, ExifProperties.DateTaken);
                var dateTaken = DateTime.ParseExact(date, "yyyy:MM:dd HH:mm:ss", null);
                result.Value = dateTaken.ToString(options.DateFormatString);
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }
    }
}
