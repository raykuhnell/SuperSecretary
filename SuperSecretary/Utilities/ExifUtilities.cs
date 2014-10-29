using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace SuperSecretary.Utilities
{
    public enum ExifProperties
    {
        CameraMaker = 0x010F,
        CameraModel = 0x0110,
        DateTaken = 0x9003
    }

    public class ExifUtilities
    {
        public static string GetProperty(string fileName, ExifProperties property)
        {
            string value = "";
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (Image image = Image.FromStream(fs, false, false))
                {
                    var propertyItem = image.GetPropertyItem((int)property);
                    value = Encoding.UTF8.GetString(propertyItem.Value, 0, propertyItem.Len - 1);
                }
            }
            return value;
        }
    }
}
